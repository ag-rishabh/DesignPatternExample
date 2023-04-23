
using DesignPattern;
using DesignPattern.AbstractFactoryDP;
using DesignPattern.FactoryDP;

//SingletonDP singleton = SingletonDP.GetInstance();
//singleton.PrintMsg("Single object created");

//PizzaStore PizzaStore = new PizzaStore();
//Pizza Pepperoni = PizzaStore.orderPiza(PizzaType.Pepperoni);

//Console.WriteLine("------------------------------------------------");

//Pizza Cheese = PizzaStore.orderPiza(PizzaType.Cheese);

IFactory win = GUIAbstractFactory.CreateFactory("Win");
IButton button = win.CreateButton();
button.PressButton();
ITextBox textBox = win.CreateTextBox();
textBox.ShowTextBox();
