#include <QtGui>
#include <QX11EmbedWidget>
#include <marble/MarbleWidget.h>
#include "commandreader.h"

int main(int argc, char *argv[])
{
    QApplication app(argc, argv);

    QX11EmbedWidget *widget = new QX11EmbedWidget;
    Marble::MarbleWidget *marble = new Marble::MarbleWidget;
    marble->setProjection(Marble::Mercator);
    marble->setMapThemeId("earth/openstreetmap/openstreetmap.dgml");

    QHBoxLayout *layout = new QHBoxLayout;
    layout->addWidget(marble);
    widget->setLayout(layout);

    if (app.arguments().count() > 1)
        widget->embedInto(app.arguments()[1].toULong());
    widget->show();

    CommandReader commandReader(marble);
    commandReader.start();

    return app.exec();
}
