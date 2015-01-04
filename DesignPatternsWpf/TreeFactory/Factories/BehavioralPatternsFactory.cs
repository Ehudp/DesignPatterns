using DesignPatterns.Utilities;
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

        

    }
}