using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Exam
{
    public class XmlExamSerializer : IExamSerializer
    {
        private readonly XmlSerializer _examSerializer;
        private readonly XmlSerializer _gradeSerializer;

        public XmlExamSerializer()
        {

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
