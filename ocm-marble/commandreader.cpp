#include "commandreader.h"
#include <QtCore>

CommandReader::CommandReader(Marble::MarbleWidget *marble)
{
    m_marble = marble;
}

void CommandReader::readCommand()
{
    QString line;
    QTextStream stream(stdin);
    line = stream.readLine();
    qDebug() << line;
}
