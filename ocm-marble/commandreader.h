#ifndef COMMANDREADER_H
#define COMMANDREADER_H

#include <QObject>
#include <marble/MarbleWidget.h>

class CommandReader : public QObject
{
    Q_OBJECT
public:
    CommandReader(Marble::MarbleWidget *marble);

public slots:
    void readCommand();

private:
    Marble::MarbleWidget *m_marble;
};

#endif // COMMANDREADER_H
