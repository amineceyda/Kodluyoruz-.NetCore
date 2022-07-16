#!/usr/bin/env python3
# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'untitled.ui'
#
# Created by: PyQt5 UI code generator 5.14.1
#
# WARNING! All changes made in this file will be lost!


from PyQt5 import QtCore, QtGui, QtWidgets
import sys
import rospy
from PyQt5.QtWidgets import (QApplication, QWidget)
from PyQt5.Qt import Qt
from geometry_msgs.msg import Twist #Hız yayınlamak için
from nav_msgs.msg import Odometry  #Konum Yayınlamak için


class MainWindow(QWidget):
    def __init__(self):
        super().__init__()
    
        
   
    rospy.init_node("manual_move") #Düğümü başlatmak için
    pub = rospy.Publisher("cmd_vel",Twist,queue_size=10)
    hiz_mesaji = Twist()
    
        
    def keyPressEvent(self, event):
        
        if event.key() == Qt.Key_Up:
            self.move(0.5 , 0.0)
        elif event.key() == Qt.Key_Down:
            self.move(-0.5, 0.0)
        elif event.key() == Qt.Key_Left:
            self.move(0.0, 0.5)
        elif event.key() == Qt.Key_Right:
            self.move(0.0, -0.5)
        elif event.key() == Qt.Key_Space:
            self.move(0.0 , 0.0)
        elif event.key() == Qt.Key_Up and event.key() == Qt.Key_Right : 
            self.move(0.5, -0.5)
        elif event.key() == Qt.Key_Up and event.key() == Qt.Key_Left :
            self.move(0.5, 0.5)
        elif event.key() == Qt.Key_Down and event.key() == Qt.Key_Right :
            self.move(-0.5, -0.5)
        elif event.key() == Qt.Key_Down and event.key() == Qt.Key_Left:
            self.move(-0.5, 0.5)
        else:
            self.move(0.0,0.0)
            print("Lütfen geçerli tuşları giriniz:")
            
        
    
    def move(self, vx, vz):
        self.hiz_mesaji.linear.x = vx
        self.hiz_mesaji.angular.z = vz
        self.pub.publish(self.hiz_mesaji)
        self.line_lineer.setText(str(self.hiz_mesaji.linear.x))
        self.line_acisal.setText(str(self.hiz_mesaji.angular.z))
        
    
        
   
        
        
        
if __name__ == '__main__':
    app = QApplication(sys.argv)
    
    demo = MainWindow()
    demo.show()
    
    sys.exit(app.exec_())
