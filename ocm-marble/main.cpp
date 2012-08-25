#include <QApplication>
#include <QX11EmbedWidget>
#include <marble/MarbleWidget.h>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QX11EmbedWidget w;
    Marble::MarbleWidget m(&w);
    if (a.arguments().count() > 1)
        w.embedInto(a.arguments()[1].toULong());
    w.show();
    
    return a.exec();
}
