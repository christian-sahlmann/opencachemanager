QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = ocm-marble
TEMPLATE = app

SOURCES += main.cpp \
    commandreader.cpp

unix|win32: LIBS += -lmarblewidget

HEADERS += \
    commandreader.h
