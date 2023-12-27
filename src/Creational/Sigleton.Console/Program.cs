// See https://aka.ms/new-console-template for more information
using Sigleton.Console;
using Singleton.Console;

Console.WriteLine("Hello, World!");


var function = SingletonWithFunction.GetInstance();
var property1 = SingletonWithProperty1.Instance;
var property2 = SingletonWithProperty2.Instance;

// function.{use another members}