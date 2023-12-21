// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.18.1

using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
////AHAHAHHAaassasas
namespace ProgettoCloud.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            string lowerCaseText = turnContext.Activity.Text.ToLowerInvariant();

            switch (lowerCaseText)
            {
                case "\\comandi":
                    var comandi = new HeroCard
                    {
                        Text = "Seleziona un argomento:",
                        Buttons = new List<CardAction>
                {
                    new CardAction(ActionTypes.ImBack, "Storia Romana", value: "Storia Romana"),
                    new CardAction(ActionTypes.ImBack, "Seconda Guerra Mondiale", value: "Seconda Guerra Mondiale"),
                    new CardAction(ActionTypes.ImBack, "Altri Comandi", value: "Altri Comandi"),
                }
                    };
                    var reply = MessageFactory.Attachment(new List<Attachment> { comandi.ToAttachment() });
                    await turnContext.SendActivityAsync(reply, cancellationToken);
                    break;

                case "storia romana":
                    var domandeStoriaRomana = new HeroCard
                    {
                        Text = "Seleziona una domanda sulla storia romana:",
                        Buttons = new List<CardAction>
                {
                    new CardAction(ActionTypes.ImBack, "Quando nasce l'impero Romano?", value: "Quando nasce l'impero Romano?"),
                    new CardAction(ActionTypes.ImBack, "Chi è stato il primo imperatore?", value: "Chi è stato il primo imperatore?"),
                    new CardAction(ActionTypes.ImBack, "Quali erano le legioni romane?", value: "Quali erano le legioni romane?"),
                    new CardAction(ActionTypes.ImBack, "Cosa sono i fasti consulares?", value: "Cosa sono i fasti consulares?"),
                    new CardAction(ActionTypes.ImBack, "Chi erano i Gracchi?", value: "Chi erano i Gracchi?"),
                    new CardAction(ActionTypes.ImBack, "Che cos'è la Pax Romana?", value: "Che cos'è la Pax Romana?"),
                    new CardAction(ActionTypes.ImBack, "Chi è Spartaco?", value: "Chi è Spartaco?"),
                    new CardAction(ActionTypes.ImBack, "Qual è la differenza tra patrizi e plebei?", value: "Qual è la differenza tra patrizi e plebei?"),
                    new CardAction(ActionTypes.ImBack, "Cosa sono i giochi gladiatori?", value: "Cosa sono i giochi gladiatori?"),
                    new CardAction(ActionTypes.ImBack, "Quando è caduto l'Impero Romano d'Occidente?", value: "Quando è caduto l'Impero Romano d'Occidente?"),
                }
                    };
                    var domandeStoriaRomanaReply = MessageFactory.Attachment(new List<Attachment> { domandeStoriaRomana.ToAttachment() });
                    await turnContext.SendActivityAsync(domandeStoriaRomanaReply, cancellationToken);
                    break;

                case "quando nasce l'impero romano?":
                    await turnContext.SendActivityAsync("L'impero Romano ha inizio nel 27 a.C. quando Ottaviano diventa il primo imperatore, noto come Augusto.");
                    break;

                case "chi è stato il primo imperatore?":
                    await turnContext.SendActivityAsync("Il primo imperatore romano è stato Ottaviano, noto anche come Augusto, che ha iniziato il suo regno nel 27 a.C.");
                    break;

                case "quali erano le legioni romane?":
                    await turnContext.SendActivityAsync("Le legioni romane erano unità militari fondamentali dell'esercito romano, composte principalmente da soldati di fanteria noti come legionari.");
                    break;

                case "cosa sono i fasti consulares?":
                    await turnContext.SendActivityAsync("I fasti consulares erano registri che elencavano i nomi dei consoli romani e altri eventi importanti del calendario.");
                    break;

                case "chi erano i Gracchi?":
                    await turnContext.SendActivityAsync("I Gracchi erano due fratelli, Tiberio e Caio Gracco, che cercarono di riformare la Repubblica Romana nel II secolo a.C.");
                    break;

                case "che cos'è la Pax Romana?":
                    await turnContext.SendActivityAsync("La Pax Romana era un periodo di relativa pace e stabilità che caratterizzò l'Impero Romano per diversi secoli.");
                    break;

                case "chi è Spartaco?":
                    await turnContext.SendActivityAsync("Spartaco fu uno schiavo gladiatore che guidò una rivolta di schiavi contro l'Impero Romano nell'antica Roma.");
                    break;

                case "qual è la differenza tra patrizi e plebei?":
                    await turnContext.SendActivityAsync("I patrizi erano membri delle classi sociali più alte a Roma, mentre i plebei erano membri delle classi sociali più basse.");
                    break;

                case "cosa sono i giochi gladiatori?":
                    await turnContext.SendActivityAsync("I giochi gladiatori erano spettacoli pubblici in cui combattenti, chiamati gladiatori, si sfidavano tra loro in arene per l'intrattenimento.");
                    break;

                case "quando è caduto l'Impero Romano d'Occidente?":
                    await turnContext.SendActivityAsync("L'Impero Romano d'Occidente è caduto nel 476 d.C. quando fu deposto l'ultimo imperatore, Romolo Augustolo.");
                    break;

                case "seconda guerra mondiale":
                    var domandeSecondaGuerraMondiale = new HeroCard
                    {
                        Text = "Seleziona una domanda sulla Seconda Guerra Mondiale:",
                        Buttons = new List<CardAction>
                {
                    new CardAction(ActionTypes.ImBack, "Quando è iniziata la Seconda Guerra Mondiale?", value: "Quando è iniziata la Seconda Guerra Mondiale?"),
                    new CardAction(ActionTypes.ImBack, "Chi erano gli Alleati?", value: "Chi erano gli Alleati?"),
                    new CardAction(ActionTypes.ImBack, "Cosa è il D-Day?", value: "Cosa è il D-Day?"),
                    new CardAction(ActionTypes.ImBack, "Chi era Adolf Hitler?", value: "Chi era Adolf Hitler?"),
                    new CardAction(ActionTypes.ImBack, "Qual è il significato di Blitzkrieg?", value: "Qual è il significato di Blitzkrieg?"),
                    new CardAction(ActionTypes.ImBack, "Cosa è l'Olocausto?", value: "Cosa è l'Olocausto?"),
                    new CardAction(ActionTypes.ImBack, "Chi era Winston Churchill?", value: "Chi era Winston Churchill?"),
                    new CardAction(ActionTypes.ImBack, "Quali sono le cause della Seconda Guerra Mondiale?", value: "Quali sono le cause della Seconda Guerra Mondiale?"),
                    new CardAction(ActionTypes.ImBack, "Cosa è successo durante la Conferenza di Yalta?", value: "Cosa è successo durante la Conferenza di Yalta?"),
                    new CardAction(ActionTypes.ImBack, "Quando è terminata la Seconda Guerra Mondiale?", value: "Quando è terminata la Seconda Guerra Mondiale?"),
                }
                    };
                    var domandeSecondaGuerraMondialeReply = MessageFactory.Attachment(new List<Attachment> { domandeSecondaGuerraMondiale.ToAttachment() });
                    await turnContext.SendActivityAsync(domandeSecondaGuerraMondialeReply, cancellationToken);
                    break;

                case "quando è iniziata la Seconda Guerra Mondiale?":
                    await turnContext.SendActivityAsync("La Seconda Guerra Mondiale è iniziata il 1º settembre 1939 quando la Germania nazista ha invaso la Polonia.");
                    break;

                case "chi erano gli Alleati?":
                    await turnContext.SendActivityAsync("Gli Alleati durante la Seconda Guerra Mondiale includevano nazioni come Stati Uniti, Regno Unito, Unione Sovietica, Francia e molti altri.");
                    break;

                case "cosa è il D-Day?":
                    await turnContext.SendActivityAsync("Il D-Day, o Giorno D, è stato l'6 giugno 1944 quando le forze Alleate sbarcarono in Normandia, segnando un importante punto di svolta nella guerra.");
                    break;

                case "chi era Adolf Hitler?":
                    await turnContext.SendActivityAsync("Adolf Hitler è stato il leader della Germania nazista durante la Seconda Guerra Mondiale.");
                    break;

                case "qual è il significato di Blitzkrieg?":
                    await turnContext.SendActivityAsync("Blitzkrieg è una tattica militare che prevede un attacco veloce e sorprendente per sconvolgere e confondere il nemico.");
                    break;

                case "cosa è l'Olocausto?":
                    await turnContext.SendActivityAsync("L'Olocausto è stato il genocidio nazista durante il quale milioni di ebrei e altri gruppi furono perseguitati e uccisi.");
                    break;

                case "chi era Winston Churchill?":
                    await turnContext.SendActivityAsync("Winston Churchill è stato il primo ministro del Regno Unito durante la Seconda Guerra Mondiale e uno dei principali leader Alleati.");
                    break;

                case "quali sono le cause della Seconda Guerra Mondiale?":
                    await turnContext.SendActivityAsync("Le cause della Seconda Guerra Mondiale includono il trattato di Versailles, l'espansionismo aggressivo e le tensioni politiche ed economiche.");
                    break;

                case "cosa è successo durante la Conferenza di Yalta?":
                    await turnContext.SendActivityAsync("Durante la Conferenza di Yalta nel 1945, i leader Alleati discussero del futuro dell'Europa dopo la Seconda Guerra Mondiale.");
                    break;

                case "quando è terminata la Seconda Guerra Mondiale?":
                    await turnContext.SendActivityAsync("La Seconda Guerra Mondiale è terminata il 2 settembre 1945 con la resa del Giappone, dopo l'uso delle bombe atomiche su Hiroshima e Nagasaki.");
                    break;


                // Aggiungi altri casi per gestire ulteriori comandi

                default:
                    var replyText = $"Messaggio: \"{turnContext.Activity.Text}\" non riconosciuto come comando";
                    await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
                    break;
            }
        }



        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Benvenuto! Sono qui per te. Scrivi \\comandi per ricevere una lista di tutti i comandi disponibili.";

            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }

    }
}
