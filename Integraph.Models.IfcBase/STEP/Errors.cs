namespace Integraph.Models.IfcBase.STEP
{
    public abstract class StepError
    {
        protected readonly int _currId;

        public StepError(int currId)
        {
            _currId = currId;
        }

        public virtual string Message => $"There was an error reading the STEP file at Id, {_currId}.";
    }

    /// <summary>
    ///     MissingIdError is generated when a STEP file references an id that does not exist.
    /// </summary>
    public class MissingIdError : StepError
    {
        private readonly int _missingId;

        public MissingIdError(int id, int missingId) : base(id)
        {
            _missingId = missingId;
        }

        public override string Message =>
            $"Id {_missingId}, referenced in constructor, {_currId}, could not be found in the file.";
    }
}