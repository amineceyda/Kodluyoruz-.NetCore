#!/usr/bin/env python3
# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'kontrol_arayuzu.ui'
#
# Created by: PyQt5 UI code generator 5.14.1
#
# WARNING! All changes made in this file will be lost!


from PyQt5 import QtCore, QtGui, QtWidgets, Qt
import sys
import rospy
from geometry_msgs.msg import Twist #Hız yayınlamak için
from nav_msgs.msg import Odometry  #Konum Yayınlamak için


class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(500, 265)
        MainWindow.setMaximumSize(QtCore.QSize(500, 265))
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.gridLayout_5 = QtWidgets.QGridLayout(self.centralwidget)
        self.gridLayout_5.setObjectName("gridLayout_5")
        self.gridLayout_3 = QtWidgets.QGridLayout()
        self.gridLayout_3.setObjectName("gridLayout_3")
        self.formLayout = QtWidgets.QFormLayout()
        self.formLayout.setObjectName("formLayout")
        self.label_lineer = QtWidgets.QLabel(self.centralwidget)
        self.label_lineer.setObjectName("label_lineer")
        self.formLayout.setWidget(0, QtWidgets.QFormLayout.LabelRole, self.label_lineer)
        self.line_lineer = QtWidgets.QLineEdit(self.centralwidget)
        self.line_lineer.setReadOnly(True)
        self.line_lineer.setObjectName("line_lineer")
        self.formLayout.setWidget(0, QtWidgets.QFormLayout.FieldRole, self.line_lineer)
        self.label_acisal = QtWidgets.QLabel(self.centralwidget)
        self.label_acisal.setObjectName("label_acisal")
        self.formLayout.setWidget(1, QtWidgets.QFormLayout.LabelRole, self.label_acisal)
        self.line_acisal = QtWidgets.QLineEdit(self.centralwidget)
        self.line_acisal.setReadOnly(True)
        self.line_acisal.setObjectName("line_acisal")
        self.formLayout.setWidget(1, QtWidgets.QFormLayout.FieldRole, self.line_acisal)
        self.gridLayout_3.addLayout(self.formLayout, 1, 0, 1, 1)
        self.label_hiz_gostergesi = QtWidgets.QLabel(self.centralwidget)
        self.label_hiz_gostergesi.setObjectName("label_hiz_gostergesi")
        self.gridLayout_3.addWidget(self.label_hiz_gostergesi, 0, 0, 1, 1)
        self.gridLayout_5.addLayout(self.gridLayout_3, 0, 1, 1, 1)
        self.gridLayout_2 = QtWidgets.QGridLayout()
        self.gridLayout_2.setObjectName("gridLayout_2")
        self.formLayout_2 = QtWidgets.QFormLayout()
        self.formLayout_2.setObjectName("formLayout_2")
        self.label_x = QtWidgets.QLabel(self.centralwidget)
        self.label_x.setObjectName("label_x")
        self.formLayout_2.setWidget(0, QtWidgets.QFormLayout.LabelRole, self.label_x)
        self.line_x = QtWidgets.QLineEdit(self.centralwidget)
        self.line_x.setReadOnly(True)
        self.line_x.setObjectName("line_x")
        self.formLayout_2.setWidget(0, QtWidgets.QFormLayout.FieldRole, self.line_x)
        self.label_y = QtWidgets.QLabel(self.centralwidget)
        self.label_y.setObjectName("label_y")
        self.formLayout_2.setWidget(1, QtWidgets.QFormLayout.LabelRole, self.label_y)
        self.line_y = QtWidgets.QLineEdit(self.centralwidget)
        self.line_y.setReadOnly(True)
        self.line_y.setObjectName("line_y")
        self.formLayout_2.setWidget(1, QtWidgets.QFormLayout.FieldRole, self.line_y)
        self.gridLayout_2.addLayout(self.formLayout_2, 1, 0, 1, 1)
        self.label_konum_gostergesi = QtWidgets.QLabel(self.centralwidget)
        self.label_konum_gostergesi.setObjectName("label_konum_gostergesi")
        self.gridLayout_2.addWidget(self.label_konum_gostergesi, 0, 0, 1, 1)
        self.gridLayout_5.addLayout(self.gridLayout_2, 1, 1, 1, 1)
        self.gridLayout_4 = QtWidgets.QGridLayout()
        self.gridLayout_4.setObjectName("gridLayout_4")
        self.label_kontrol_paneli = QtWidgets.QLabel(self.centralwidget)
        self.label_kontrol_paneli.setObjectName("label_kontrol_paneli")
        self.gridLayout_4.addWidget(self.label_kontrol_paneli, 0, 0, 1, 1)
        self.gridLayout = QtWidgets.QGridLayout()
        self.gridLayout.setObjectName("gridLayout")
        self.buton_dur = QtWidgets.QPushButton(self.centralwidget)
        self.buton_dur.setObjectName("buton_dur")
        self.gridLayout.addWidget(self.buton_dur, 1, 1, 1, 1)
        self.buton_geri = QtWidgets.QPushButton(self.centralwidget)
        self.buton_geri.setObjectName("buton_geri")
        self.gridLayout.addWidget(self.buton_geri, 2, 1, 1, 1)
        self.buton_sol = QtWidgets.QPushButton(self.centralwidget)
        self.buton_sol.setObjectName("buton_sol")
        self.gridLayout.addWidget(self.buton_sol, 1, 0, 1, 1)
        self.buton_sag = QtWidgets.QPushButton(self.centralwidget)
        self.buton_sag.setObjectName("buton_sag")
        self.gridLayout.addWidget(self.buton_sag, 1, 2, 1, 1)
        self.buton_ileri = QtWidgets.QPushButton(self.centralwidget)
        self.buton_ileri.setObjectName("buton_ileri")
        self.gridLayout.addWidget(self.buton_ileri, 0, 1, 1, 1)
        self.gridLayout_4.addLayout(self.gridLayout, 1, 0, 1, 1)
        self.gridLayout_5.addLayout(self.gridLayout_4, 0, 0, 1, 1)
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 500, 22))
        self.menubar.setObjectName("menubar")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "Kontrol Arayüzü"))
        self.label_lineer.setText(_translate("MainWindow", "Lineer Hız (m/s):"))
        self.label_acisal.setText(_translate("MainWindow", "Acisal Hız (rad/s):"))
        self.label_hiz_gostergesi.setText(_translate("MainWindow", "Hız Göstergesi"))
        self.label_x.setText(_translate("MainWindow", "Konum (X)(m):"))
        self.label_y.setText(_translate("MainWindow", "Konum (Y)(m):"))
        self.label_konum_gostergesi.setText(_translate("MainWindow", "Konum Göstergesi"))
        self.label_kontrol_paneli.setText(_translate("MainWindow", "Kontrol Paneli"))
        self.buton_dur.setText(_translate("MainWindow", "Dur"))
        self.buton_geri.setText(_translate("MainWindow", "Geri"))
        self.buton_sol.setText(_translate("MainWindow", "Sol"))
        self.buton_sag.setText(_translate("MainWindow", "Sağ"))
        self.buton_ileri.setText(_translate("MainWindow", "İleri"))
        
        rospy.init_node("kontrol_arayuz") #Düğümü başlatmak için
        self.pub = rospy.Publisher("cmd_vel",Twist,queue_size=10)
        self.hiz_mesaji = Twist()
        rospy.Subscriber("odom",Odometry,self.odomCallback)

#
        self.buton_dur.clicked.connect(self.aracDur)
        self.buton_ileri.clicked.connect(self.aracIleri)
        self.buton_geri.clicked.connect(self.aracGeri)
        self.buton_sag.clicked.connect(self.aracSag)
        self.buton_sol.clicked.connect(self.aracSol)
        
#
    
    def keyPressEvent(self, event):
        if event.key() == QtCore.Qt.Key_Left:
            print("Sola git")
        elif event.key() == QtCore.Qt.Key_Right:
            print("Saga git")
        elif event.key() == QtCore.Qt.Key_Space:
            print("dur")
        elif event.key() == QtCore.Qt.Key_Down:
            print("geri")
        elif event.key() == QtCore.Qt.Key_Up:
            print("ileri")
        else:
            print("Lütfen yön tuşlarını kullanınız")
            
    
    
            
        self.line_acisal.setText(str("0,0"))
        self.line_lineer.setText(str("0,0"))
        self.line_x.setText(str("0,0"))
        self.line_y.setText(str("0,0"))

    def odomCallback(self,mesaj):#konumu her abonelikte güncellemesi için
        self.line_x.setText(str(mesaj.pose.pose.position.x))
        self.line_y.setText(str(mesaj.pose.pose.position.y))
    
    def aracDur(self):
        self.hiz_mesaji.linear.x = 0.0
        self.hiz_mesaji.angular.z = 0.0
        self.pub.publish(self.hiz_mesaji)
        self.line_lineer.setText(str(self.hiz_mesaji.linear.x))
        self.line_acisal.setText(str(self.hiz_mesaji.angular.z))
        
    def aracIleri(self):
        self.hiz_mesaji.linear.x = 0.5  #tuşa basıldığında 1 metrelik hız ile hızlansın
        self.hiz_mesaji.angular.z = 0.0 #düz gittiği için açısal hız sıfır
        self.pub.publish(self.hiz_mesaji)
        self.line_lineer.setText(str(self.hiz_mesaji.linear.x))
        self.line_acisal.setText(str(self.hiz_mesaji.angular.z))
        
    def aracGeri(self):
        self.hiz_mesaji.linear.x = -0.5 #geri gitmesi için
        self.hiz_mesaji.angular.z = 0.0
        self.pub.publish(self.hiz_mesaji)
        self.line_lineer.setText(str(self.hiz_mesaji.linear.x))
        self.line_acisal.setText(str(self.hiz_mesaji.angular.z))
        
    def aracSol(self):
        self.hiz_mesaji.linear.x = 0.0
        self.hiz_mesaji.angular.z = 0.25  #sola dönmesi için
        self.pub.publish(self.hiz_mesaji)
        self.line_lineer.setText(str(self.hiz_mesaji.linear.x))
        self.line_acisal.setText(str(self.hiz_mesaji.angular.z))
        
    def aracSag(self):
        self.hiz_mesaji.linear.x = 0.0
        self.hiz_mesaji.angular.z = -0.25  #sağa dönmesi için
        self.pub.publish(self.hiz_mesaji)
        self.line_lineer.setText(str(self.hiz_mesaji.linear.x))
        self.line_acisal.setText(str(self.hiz_mesaji.angular.z))
    

if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_MainWindow()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())
