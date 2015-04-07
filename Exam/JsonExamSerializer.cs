using System;
using System.Web.Script.Serialization;

namespace Exam
{
    public class JsonExamSerializer : IExamSerializer
    {
        private readonly JavaScriptSerializer _serializer;

        public JsonExamSerializer()
        {
            _serializer = new JavaScriptSerializer();
        }

        public string SerializeExam(Exam exam)
        {
            throw new NotImplementedException();
        }

        public Exam DeserializeExam(string text)
        {
            throw new NotImplementedException();
        }

        public string SerializeGrade(StudentGrade exam)
        {
            throw new NotImplementedException();
        }

        public StudentGrade DeserializeGrade(string text)
        {
            throw new NotImplementedException();
        }
    }
}
