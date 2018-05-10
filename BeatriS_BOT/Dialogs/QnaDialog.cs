using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BeatriS_BOT.Dialogs
{
    [Serializable]
    public class QnaDialog : QnAMakerDialog
    {
        

        public QnaDialog() : base(new QnAMakerService(new QnAMakerAttribute("27365142-3b9f-43ac-9a06-61bf4dba4577", "50a1cb4a-079b-4d77-92b2-d7969a969a16", "Não encontrei a tua resposta", 0.3, 3, "https://qnamakertesteva.azurewebsites.net/qnamaker")))
        { }

        public static string QnaEndpointKey { get; }
        public static string QnaKnowledgebaseId { get; }
        public static string QnaHost { get; }
    }
}