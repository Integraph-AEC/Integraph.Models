using System;

namespace Integraph.Models.IfcBase.STEP
{
	/// <summary>
	///     Exception thrown when an unknown type is encountered.
	/// </summary>
	public class StepUnknownTypeException : Exception
    {
        private readonly string _desiredType;

        public StepUnknownTypeException(string desiredType)
        {
            _desiredType = desiredType;
        }

        public override string Message =>
            $"A type corresponding to, {_desiredType}, cannot be found in IFC-dotnet assembly.";
    }

	/// <summary>
	///     Exception thrown when a type cannot be coerced into a target type.
	/// </summary>
	public class StepParserException : Exception
    {
        private readonly Type _destinationType;
        private readonly string _parseValue;

        public StepParserException(Type destinationType, string parseValue)
        {
            _destinationType = destinationType;
            _parseValue = parseValue;
        }

        public override string Message =>
            $"The specified value, {_parseValue}, could not be coerced into the type, {_destinationType.Name}";
    }

	/// <summary>
	///     Exception thrown when there is a mismatch in parameters between the type and what is provided in the STEP file.
	/// </summary>
	public class StepParameterMismatchException : Exception
    {
        private readonly int _expectedCount;
        private readonly int _providedCount;
        private readonly Type _type;

        public StepParameterMismatchException(Type type, int providedCount, int expectedCount)
        {
            _type = type;
            _providedCount = providedCount;
            _expectedCount = expectedCount;
        }

        public override string Message =>
            $"{_type}'s constructor expects {_expectedCount} parameters but {_providedCount} parameters are provided.";
    }

	/// <summary>
	///     Exception thrown when an identifier is found for which there is not construction.
	/// </summary>
	public class StepIdentifierNotFoundException : Exception
    {
        private readonly int _currLine;
        private readonly int _id;

        public StepIdentifierNotFoundException(int id, int currLine)
        {
            _id = id;
            _currLine = currLine;
        }

        public override string Message =>
            $"The id, {_id}, found at line, {_currLine}, could not be found in the STEP file being opened.";
    }

	/// <summary>
	///     Exception thrown when the specified id does not correspond to an instance in the Model.
	/// </summary>
	public class InstanceNotFoundException : Exception
    {
        private readonly Guid _id;

        public InstanceNotFoundException(Guid id)
        {
            _id = id;
        }

        public override string Message => $"An instance with Id, {_id}, does not exist in the model.";
    }

	/// <summary>
	///     Exception thrown when an instance with the same id already exists in the model.
	/// </summary>
	public class DuplicateInstanceException : Exception
    {
        private readonly Guid _id;

        public DuplicateInstanceException(Guid id)
        {
            _id = id;
        }

        public override string Message => $"An instance with the specified Id, {_id}, already exists in the Model.";
    }
}