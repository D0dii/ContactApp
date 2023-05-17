
using ContactApp;
using ContactApp.StatesOfMachine;
using Newtonsoft.Json;

string contactsSerialized = File.ReadAllText(@"c:\Users\marci\Contacts\Contacts.json");
List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(contactsSerialized);


int choice = -1;
StateMachine stateMachine = new StateMachine();
while(choice != 0)
{
    Console.WriteLine("Choose what you would like to do:");
    Console.WriteLine("1 - display all contacts");
    Console.WriteLine("2 - add contact");
    Console.WriteLine("3 - delete contact");
    Console.WriteLine("4 - call contact");
    Console.WriteLine("5 - find contact by number");
    Console.WriteLine("6 - find contact by name of contact");
    Console.WriteLine("0 - exit");
    Boolean succes = int.TryParse(Console.ReadLine(),out choice);
    while (!succes||choice<0||choice>6)
    {
        Console.WriteLine("Invalid input:");
        succes = int.TryParse(Console.ReadLine(), out choice);
    }
    switch (choice)
    {
        case 1:
            stateMachine.CurrentState = new DisplayState();
            stateMachine.doAction(contacts);
            break;
        case 2:
            stateMachine.CurrentState = new AddState();
            stateMachine.doAction(contacts);
            break;
    }
}
Console.WriteLine("Bye bye :)");



string serializedContacts = JsonConvert.SerializeObject(contacts);
File.WriteAllText(@"c:\Users\marci\Contacts\Contacts.json",serializedContacts);