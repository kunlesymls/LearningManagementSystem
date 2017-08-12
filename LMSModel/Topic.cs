﻿using LMSModel.BlogPost;
using LMSModel.CBTE;
using System.Collections.Generic;

namespace LMSModel
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public int ExpectedTime { get; set; }
        public virtual Module Module { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<MaterialUpload> MaterialUploads { get; set; }
        public virtual ICollection<TopicAssignment> TopicAssignments { get; set; }
        public virtual ICollection<SubmitAssignment> SubmitAssignments { get; set; }
        public virtual ICollection<StudentTestLog> StudentTestLogs { get; set; }
        public virtual ICollection<QuizRule> QuizRules { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual ICollection<StudentQuestion> StudentQuestions { get; set; }

    }
}