// See https://aka.ms/new-console-template for more information
using Sigleton.Console;
using Singleton.Console;

Console.WriteLine("Hello, World!");


var eager = SingletonEager.GetInstance();
var lazy = SingletonLazy.GetInstance();
var property1 = SingletonLazyWithProperty.Instance;
var property2 = SingletonEagerWithProperty.Instance;

// function.{use another members}