#ifndef COMMANDREADER_H
#define COMMANDREADER_H

#include <QThread>
#include <marble/MarbleWidget.h>

class CommandReader : public QThread
{
public:
    CommandReader(Marble::MarbleWidget *marble);
    void run();
private:
    Marble::MarbleWidget *m_marble;
};

#endif // COMMANDREADER_H
