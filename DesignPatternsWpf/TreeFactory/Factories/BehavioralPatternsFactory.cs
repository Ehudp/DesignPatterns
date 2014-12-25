using DesignPatterns.Utilities;
using DesignPatternsWpf.Model;
using DesignPatternsWpf.Services;
using System;
using System.Collections.Generic;

namespace DesignPatternsWpf.TreeFactory.Factories
{
    public class BehavioralPatternsFactory : AbstractPatternsFactory
    {

        protected override PatternDetails CreatePatternDetails()
        {
            var behavioralDetails = new PatternDetails
            {
                Name = "Behavioral",
                Header = "Behavioral Patterns",
            };

            behavioralDetails.Patterns.Add(this.GetPatternsFromFactory<ChainOfRespPatternsFactory>());
            behavioralDetails.Patterns.Add(this.GetPatternsFromFactory<CommandPatternsFactory>());
         
            
            
            return behavioralDetails;
        }

        public class  ChainOfRespPatternsFactory : AbstractPatternsFactory
        {
            protected override PatternDetails CreatePatternDetails()
            {
                var chainOfRespParent = new PatternDetails
                {
                    Name = "ChainOfResp",
                    Header = "ChainOfResp",
                    Detailes = "A way of passing a request between a chain of objects - " +
                               "Avoid coupling the sender of a request to its receiver by giving more than one object"
                               +" a chance to handle the request. Chain the receiving objects and "
                               +"pass the request along the chain until an object handles it.",
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
                        +" which several linked objects (the Chain) are offered the opportunity to "
                        +"respond to a request or hand it off to the object next in line.",
                    ImageUrl ="",
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
                    +" which several linked managers and executives can respond to a purchase request or hand it"
                    +"off to a superior. Each position has can have its own set of rules which orders they can approve.",
                    ImageUrl ="",
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
                    Detailes = "TThis real-world code demonstrates the Command pattern used in a simple" +
                               " calculator with unlimited number of undo's and redo's. Note that in C#  " +
                               "the word 'operator' is a keyword. Prefixing it with '@' allows using it as an identifier.",
                    ImageUrl = "",
                    UrlsList = new List<Uri>
                {
                    new Uri("http://www.dofactory.com/net/chain-of-responsibility-design-pattern#rea"),
                }
                };

                commandParent.Patterns.Add(commandStructural);
                commandParent.Patterns.Add(commandRealWorld);

                return commandParent;
            }
        }

    }
}