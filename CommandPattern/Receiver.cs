using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class Receiver : IReceiver<Command, IState>
    {
        public IState Handle(Command command)
        {
            command.Execute();
            return new State(200, "Sucesso");
        }
    }
}
