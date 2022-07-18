using System.Collections.Generic;

namespace Multilingo.Entities
{
    public class Term
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string TermUa { get; set; }
        public string DefinitionUa { get; set; }
        public string TermEn { get; set; }
        public string DefinitionEn { get; set; }
        public string TermFr { get; set; }
        public string DefinitionFr { get; set; }
    }
}
