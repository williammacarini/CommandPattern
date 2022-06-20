using CommandPattern;

var receiver = new Receiver();
var commandResult = (State)receiver.Handle(new Command(1, "Comando 1"));

Console.WriteLine($"{commandResult.StatusCode} - {commandResult.Message}");

Console.ReadLine();