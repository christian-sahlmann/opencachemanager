#include <QApplication>
#include <QX11EmbedWidget>
#include <marble/MarbleWidget.h>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QX11EmbedWidget w;
    Marble::MarbleWidget m(&w);
    w.show();
    
    return a.exec();
}
