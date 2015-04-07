using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace Exam
{
    public class QuestionConverter
    {
        public const string QuestionTypeField = "QuestionType";
        public const string AnswersField = "Answers";
        public const string MultipleChoiceQuestionType = "MultipleChoiceQuestion";
        public const string SingleChoiceQuestionType = "SingleChoiceQuestion";
        public const string OpenQuestionType = "OpenQuestion";
        public const string TitleField = "Title";
        public const string CorrectAnswersField = "CorrectAnswers";
        public const string CorrectAnswerField = "CorrectAnswer";

        private List<T> GetListFromObject<T>(object obj)
        {
            return (obj as System.Collections.ArrayList).Cast<T>().ToList();
        }
    }
}
