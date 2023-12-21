// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.18.1

using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
//
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

                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }

    }
}
