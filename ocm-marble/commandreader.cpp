#include "commandreader.h"
#include <QtCore>

CommandReader::CommandReader(Marble::MarbleWidget *marble) :
    QThread()
{
    m_marble = marble;
}

void CommandReader::run()
{
    QString line;
    QTextStream stream(stdin);
    forever {
        qDebug() << "do";
        line = stream.readLine();
        qDebug() << line;
        qDebug() << "/do";
     }
}
