#include "commandreader.h"
#include <QtCore>

CommandReader::CommandReader(Marble::MarbleWidget *marble) :
    QThread()
{
    m_marble = marble;
    marble->connect(this, SIGNAL(zoomTo(qreal,qreal)), SLOT(centerOn(qreal,qreal)));
}

void CommandReader::run()
{
    QTextStream stream(stdin);
    forever {
        QString line = stream.readLine();
        QStringList list = line.split(QRegExp("[\\(\\),]"));
        qDebug() << list;
        if (list[0] == "zoomTo")
            emit zoomTo(list[2].toDouble(), list[1].toDouble());
     }
}
