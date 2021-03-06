﻿using DesignPatterns.Utilities;
using DesignPatternsWpf.Model;
using DesignPatternsWpf.Services;
using System;
using System.Collections.Generic;

namespace DesignPatternsWpf.TreeFactory.Factories
{
    public class BehavioralPatternsFactory : AbstractPatternsFactory
    {
        private readonly List<AbstractPatternsFactory> _factoryTypes = new List<AbstractPatternsFactory>
        {
           new ChainOfRespPatternsFactory(),
           new CommandPatternsFactory(),
           new InterpreterPatternsFactory(),
           new IteratorPatternsFactory(),
           new MediatorPatternsFactory(),
           new MementoPatternsFactory(),
           new ObserverPatternsFactory(),
           new StatePatternsFactory(),
           new StrategyPatternsFactory(),
           new TemplateMethodPatternsFactory(),
           new VisitorMethodPatternsFactory(),
        };

        protected override PatternDetails CreatePatternDetails()
        {
            var behavioralDetails = new PatternDetails
            {
                Name = "Behavioral",
                Header = "Behavioral Patterns",
            };

            _factoryTypes.ForEach(factoryType => behavioralDetails.Patterns.Add(factoryType.GetPatternDetails()));
          
            return behavioralDetails;
        }

        public class ChainOfRespPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var chainOfRespParent = new PatternDetails
                {
                    Name = "ChainOfResp",
                    Header = "ChainOfResp",
                    Detailes = "A way of passing a request between a chain of objects - " +
                               "Avoid coupling the sender of a request to its receiver by giving more than one object"
                               + " a chance to handle the request. Chain the receiving objects and "
                               + "pass the request along the chain until an object handles it.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/chain-of-responsibility-design-pattern"),
                }
                };

                var chainOfRespStructural = new PatternDetails
                {
                    Name = "ChainOfRespStructural",
                    Header = "ChainOfResp Structural",
                    Method = MethodService.ChainOfRespStructural,
                    Detailes =
                        "This structural code demonstrates the Chain of Responsibility pattern in"
                        + " which several linked objects (the Chain) are offered the opportunity to "
                        + "respond to a request or hand it off to the object next in line.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/chain-of-responsibility-design-pattern#str"),
                }
                };


                var chainOfRespRealWorld = new PatternDetails
                {
                    Name = "ChainOfRespRealWorld",
                    Header = "ChainOfResp Real World",
                    Method = MethodService.ChainOfRespRealWorld,
                    Detailes = "This real-world code demonstrates the Chain of Responsibility pattern in"
                    + " which several linked managers and executives can respond to a purchase request or hand it"
                    + "off to a superior. Each position has can have its own set of rules which orders they can approve.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/chain-of-responsibility-design-pattern#rea"),
                }
                };

                chainOfRespParent.Patterns.Add(chainOfRespStructural);
                chainOfRespParent.Patterns.Add(chainOfRespRealWorld);

                return chainOfRespParent;
            }
        }

        public class CommandPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var commandParent = new PatternDetails
                {
                    Name = "Command",
                    Header = "Command",
                    Detailes = "Encapsulate a command request as an object - " +
                               "Encapsulate a request as an object, thereby letting you parameterize clients with " +
                               "different requests, queue or log requests, and support undoable operations.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Command-design-pattern"),
                }
                };

                var commandStructural = new PatternDetails
                {
                    Name = "CommandStructural",
                    Header = "Command Structural",
                    Method = MethodService.CommandStructural,
                    Detailes =
                        "This structural code demonstrates the Command pattern which" +
                        " stores requests as objects allowing clients to execute or playback the requests.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Command-design-pattern#str"),
                }
                };


                var commandRealWorld = new PatternDetails
                {
                    Name = "CommandRealWorld",
                    Header = "Command Real World",
                    Method = MethodService.CommandRealWorld,
                    Detailes = "This real-world code demonstrates the Command pattern used in a simple" +
                               " calculator with unlimited number of undo's and redo's. Note that in C#  " +
                               "the word 'operator' is a keyword. Prefixing it with '@' allows using it as an identifier.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Command-design-pattern#rea"),
                }
                };

                commandParent.Patterns.Add(commandStructural);
                commandParent.Patterns.Add(commandRealWorld);

                return commandParent;
            }
        }

        public class InterpreterPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var interpreterParent = new PatternDetails
                {
                    Name = "Interpreter",
                    Header = "Interpreter",
                    Detailes = "A way to include language elements in a program - " +
                               "Given a language, define a representation for its grammar along with an " +
                               "interpreter that uses the representation to interpret sentences in the language.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Interpreter-design-pattern"),
                }
                };

                var interpreterStructural = new PatternDetails
                {
                    Name = "InterpreterStructural",
                    Header = "Interpreter Structural",
                    Method = MethodService.InterpreterStructural,
                    Detailes =
                        "This structural code demonstrates the Interpreter patterns, which using a " +
                        "defined grammer, provides the interpreter that processes parsed statements.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Interpreter-design-pattern#str"),
                }
                };


                var interpreterRealWorld = new PatternDetails
                {
                    Name = "InterpreterRealWorld",
                    Header = "Interpreter Real World",
                    Method = MethodService.InterpreterRealWorld,
                    Detailes = "This real-world code demonstrates the Interpreter " +
                               "pattern which is used to convert a Roman numeral to a decimal.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Interpreter-design-pattern#rea"),
                }
                };

                interpreterParent.Patterns.Add(interpreterStructural);
                interpreterParent.Patterns.Add(interpreterRealWorld);

                return interpreterParent;
            }
        }

        public class IteratorPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var iteratorParent = new PatternDetails
                {
                    Name = "Iterator",
                    Header = "Iterator",
                    Detailes = "Sequentially access the elements of a collection - " +
                               "Provide a way to access the elements of an aggregate object" +
                               " sequentially without exposing its underlying representation.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Iterator-design-pattern"),
                }
                };

                var iteratorStructural = new PatternDetails
                {
                    Name = "IteratorStructural",
                    Header = "Iterator Structural",
                    Method = MethodService.IteratorStructural,
                    Detailes =
                        "This structural code demonstrates the Iterator pattern which provides for a way to traverse (iterate) over" +
                        " a collection of items without detailing the underlying structure of the collection.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Iterator-design-pattern#str"),
                }
                };


                var iteratorRealWorld = new PatternDetails
                {
                    Name = "IteratorRealWorld",
                    Header = "Iterator Real World",
                    Method = MethodService.IteratorRealWorld,
                    Detailes = "This real-world code demonstrates the Iterator pattern which is used to" +
                               " iterate over a collection of items and skip a specific number of items each iteration.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Iterator-design-pattern#rea"),
                }
                };

                iteratorParent.Patterns.Add(iteratorStructural);
                iteratorParent.Patterns.Add(iteratorRealWorld);

                return iteratorParent;
            }
        }

        public class MediatorPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var mediatorParent = new PatternDetails
                {
                    Name = "Mediator",
                    Header = "Mediator",
                    Detailes = "Defines simplified communication between classes - " +
                               "Define an object that encapsulates how a set of objects interact. Mediator promotes loose " +
                               "coupling by keeping objects from referring to each other explicitly, and it lets" +
                               " you vary their interaction independently.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Mediator-design-pattern"),
                }
                };

                var mediatorStructural = new PatternDetails
                {
                    Name = "MediatorStructural",
                    Header = "Mediator Structural",
                    Method = MethodService.MediatorStructural,
                    Detailes =
                        "This structural code demonstrates the Mediator pattern facilitating loosely coupled communication " +
                        "between different objects and object types. The mediator is a central hub through which" +
                        " all interaction must take place.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Mediator-design-pattern#str"),
                }
                };


                var mediatorRealWorld = new PatternDetails
                {
                    Name = "MediatorRealWorld",
                    Header = "Mediator Real World",
                    Method = MethodService.MediatorRealWorld,
                    Detailes = "This real-world code demonstrates the Mediator pattern facilitating loosely" +
                               " coupled communication between different Participants registering with a Chatroom. " +
                               "The Chatroom is the central hub through which all communication takes place." +
                               " At this point only one-to-one communication is implemented in the Chatroom, " +
                               "but would be trivial to change to one-to-many.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Mediator-design-pattern#rea"),
                }
                };

                mediatorParent.Patterns.Add(mediatorStructural);
                mediatorParent.Patterns.Add(mediatorRealWorld);

                return mediatorParent;
            }
        }

        public class MementoPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var mementoParent = new PatternDetails
                {
                    Name = "Memento",
                    Header = "Memento",
                    Detailes = "Capture and restore an object's internal state - " +
                               "Without violating encapsulation, capture and externalize an object's " +
                               "internal state so that the object can be restored to this state later.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Memento-design-pattern"),
                }
                };

                var mementoStructural = new PatternDetails
                {
                    Name = "MementoStructural",
                    Header = "Memento Structural",
                    Method = MethodService.MementoStructural,
                    Detailes =
                        "This structural code demonstrates the Memento pattern which" +
                        " temporary saves and restores another object's internal state.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Memento-design-pattern#str"),
                }
                };


                var mementoRealWorld = new PatternDetails
                {
                    Name = "MementoRealWorld",
                    Header = "Memento Real World",
                    Method = MethodService.MementoRealWorld,
                    Detailes = "This real-world code demonstrates the Memento pattern" +
                               " which temporarily saves and then restores the SalesProspect's internal state.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Memento-design-pattern#rea"),
                }
                };

                mementoParent.Patterns.Add(mementoStructural);
                mementoParent.Patterns.Add(mementoRealWorld);

                return mementoParent;
            }
        }

        public class ObserverPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var observerParent = new PatternDetails
                {
                    Name = "Observer",
                    Header = "Observer",
                    Detailes = "A way of notifying change to a number of classes - " +
                               "Define a one-to-many dependency between objects so that when one object" +
                               " changes state, all its dependents are notified and updated automatically.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Observer-design-pattern"),
                }
                };

                var observerStructural = new PatternDetails
                {
                    Name = "ObserverStructural",
                    Header = "Observer Structural",
                    Method = MethodService.ObserverStructural,
                    Detailes =
                        "This structural code demonstrates the Observer pattern in which " +
                        "registered objects are notified of and updated with a state change.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Observer-design-pattern#str"),
                }
                };


                var observerRealWorld = new PatternDetails
                {
                    Name = "ObserverRealWorld",
                    Header = "Observer Real World",
                    Method = MethodService.ObserverRealWorld,
                    Detailes = "This real-world code demonstrates the Observer pattern in" +
                               " which registered investors are notified every time a stock changes value.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Observer-design-pattern#rea"),
                }
                };

                observerParent.Patterns.Add(observerStructural);
                observerParent.Patterns.Add(observerRealWorld);

                return observerParent;
            }
        }

        public class StatePatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var stateParent = new PatternDetails
                {
                    Name = "State",
                    Header = "State",
                    Detailes = "Alter an object's behavior when its state changes - " +
                               "Allow an object to alter its behavior when its" +
                               " internal state changes. The object will appear to change its class.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/State-design-pattern"),
                }
                };

                var stateStructural = new PatternDetails
                {
                    Name = "StateStructural",
                    Header = "State Structural",
                    Method = MethodService.StateStructural,
                    Detailes =
                        "This structural code demonstrates the State pattern which allows an object to " +
                        "behave differently depending on " +"its internal state. The difference in behavior " +
                        "is delegated to objects that represent this state.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/State-design-pattern#str"),
                }
                };


                var stateRealWorld = new PatternDetails
                {
                    Name = "StateRealWorld",
                    Header = "State Real World",
                    Method = MethodService.StateRealWorld,
                    Detailes = "This real-world code demonstrates the State pattern which allows an Account " +
                               "to behave differently depending on its balance. The difference in " +
                               "behavior is delegated to State objects called RedState, SilverState and GoldState." +
                               " These states represent overdrawn accounts, starter accounts, and accounts in good standing.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/State-design-pattern#rea"),
                }
                };

                stateParent.Patterns.Add(stateStructural);
                stateParent.Patterns.Add(stateRealWorld);

                return stateParent;
            }
        }

        public class StrategyPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var strategyParent = new PatternDetails
                {
                    Name = "Strategy",
                    Header = "Strategy",
                    Detailes = "Encapsulates an algorithm inside a class - " +
                               "Define a family of algorithms, encapsulate each one, and make them interchangeable. " +
                               "Strategy lets the algorithm vary independently from clients that use it.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Strategy-design-pattern"),
                }
                };

                var strategyStructural = new PatternDetails
                {
                    Name = "StrategyStructural",
                    Header = "Strategy Structural",
                    Method = MethodService.StrategyStructural,
                    Detailes =
                        "This structural code demonstrates the Strategy pattern which encapsulates functionality " +
                        "in the form of an object. This allows clients to dynamically change algorithmic strategies.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Strategy-design-pattern#str"),
                }
                };


                var strategyRealWorld = new PatternDetails
                {
                    Name = "StrategyRealWorld",
                    Header = "Strategy Real World",
                    Method = MethodService.StrategyRealWorld,
                    Detailes = "This real-world code demonstrates the Strategy pattern which " +
                               "encapsulates sorting algorithms in the form of sorting objects." +
                               " This allows clients to dynamically change sorting strategies including" +
                               " Quicksort, Shellsort, and Mergesort.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Strategy-design-pattern#rea"),
                }
                };

                strategyParent.Patterns.Add(strategyStructural);
                strategyParent.Patterns.Add(strategyRealWorld);

                return strategyParent;
            }
        }

        public class TemplateMethodPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var templateMethodParent = new PatternDetails
                {
                    Name = "TemplateMethod",
                    Header = "Template Method",
                    Detailes = "Defer the exact steps of an algorithm to a subclass - " +
                               "Define the skeleton of an algorithm in an operation, deferring " +
                               "some steps to subclasses. Template Method lets subclasses redefine certain " +
                               "steps of an algorithm without changing the algorithm's structure.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Template-Method-design-pattern"),
                }
                };

                var templateMethodStructural = new PatternDetails
                {
                    Name = "TemplateMethodStructural",
                    Header = "TemplateMethod Structural",
                    Method = MethodService.TemplateMethodStructural,
                    Detailes =
                        "This structural code demonstrates the Template method which provides a skeleton " +
                        "calling sequence of methods. One or more steps can be deferred to subclasses which" +
                        " implement these steps without changing the overall calling sequence.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Template-Method-design-pattern#str"),
                }
                };


                var templateMethodRealWorld = new PatternDetails
                {
                    Name = "TemplateMethodRealWorld",
                    Header = "TemplateMethod Real World",
                    Method = MethodService.TemplateMethodRealWorld,
                    Detailes = "This real-world code demonstrates a Template method named Run() " +
                               "which provides a skeleton calling sequence of methods. Implementation of " +
                               "these steps are deferred to the CustomerDataObject subclass which implements the " +
                               "Connect, Select, Process, and Disconnect methods.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Template-Method-design-pattern#rea"),
                }
                };

                templateMethodParent.Patterns.Add(templateMethodStructural);
                templateMethodParent.Patterns.Add(templateMethodRealWorld);

                return templateMethodParent;
            }
        }

        public class VisitorMethodPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var visitorParent = new PatternDetails
                {
                    Name = "Visitor",
                    Header = "Visitor",
                    Detailes = "Defines a new operation to a class without change - " +
                               "Represent an operation to be performed on the elements of an object structure." +
                               " Visitor lets you define a new operation without changing the classes of the" +
                               " elements on which it operates.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Visitor-design-pattern"),
                }
                };

                var visitorStructural = new PatternDetails
                {
                    Name = "VisitorStructural",
                    Header = "Visitor Structural",
                    Method = MethodService.VisitorStructural,
                    Detailes =
                        "This structural code demonstrates the Visitor pattern in which an object " +
                        "traverses an object structure and performs the same operation on each node in " +
                        "this structure. Different visitor objects define different operations.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Visitor-design-pattern#str"),
                }
                };


                var visitorRealWorld = new PatternDetails
                {
                    Name = "VisitorRealWorld",
                    Header = "Visitor Real World",
                    Method = MethodService.VisitorRealWorld,
                    Detailes = "This real-world code demonstrates the Visitor pattern in which two objects " +
                               "traverse a list of Employees and performs the same operation on each Employee." +
                               " The two visitor objects define different operations -- one adjusts vacation days and the other income.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/Visitor-design-pattern#rea"),
                }
                };

                visitorParent.Patterns.Add(visitorStructural);
                visitorParent.Patterns.Add(visitorRealWorld);

                return visitorParent;
            }
        }

    }
}