#include <QApplication>
#include <marble/MarbleWidget.h>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    Marble::MarbleWidget m;
    m.show();
    
    return a.exec();
}
