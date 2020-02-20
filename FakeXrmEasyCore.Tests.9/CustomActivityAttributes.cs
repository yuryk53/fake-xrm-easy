using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeXrmEasy.Tests._9
{
	using System;

	/// <summary>
	/// A required attribute of a parameter if the parameter is of type EntityReference.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class ReferenceTargetAttribute : Attribute
	{
		/// <summary>
		/// A required attribute of a parameter if the parameter is of type EntityReference.
		/// </summary>
		/// <param name="entityName">The name of the target entity</param>
		public ReferenceTargetAttribute(string entityName)
		{
			_entityName = entityName;
		}

		/// <summary>
		/// The name of the target entity
		/// </summary>
		public string EntityName
		{
			get { return _entityName; }
		}

		private string _entityName;
	}

	/// <summary>
	/// A required attribute of a parameter if the parameter is of type OptionSetValue.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class AttributeTargetAttribute : Attribute
	{
		/// <summary>
		/// A required attribute of a parameter if the parameter is of type OptionSetValue.
		/// </summary>
		/// <param name="entityName">The target entity name.</param>
		/// <param name="attributeName">The name of the target attribute of the entity.</param>

		public AttributeTargetAttribute(string entityName, string attributeName)
		{
			_entityName = entityName;
			_attributeName = attributeName;
		}

		/// <summary>
		/// The target entity name.
		/// </summary>
		public string EntityName
		{
			get { return _entityName; }
		}

		/// <summary>
		/// The name of the target attribute of the entity.
		/// </summary>
		public string AttributeName
		{
			get { return _attributeName; }
		}

		private string _attributeName;
		private string _entityName;
	}

	/// <summary>
	/// A default value that is assigned to a parameter. This attribute is optional.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DefaultAttribute : Attribute
	{
		/// <summary>
		/// Set the default value of a parameter.
		/// </summary>
		/// <param name="value">The default value</param>
		public DefaultAttribute(string value)
			: this(value, null)
		{
		}

		/// <summary>
		/// Set the default value for an EntityReference.
		/// </summary>
		/// <param name="value">The value in form of a guid.</param>
		/// <param name="entityName">The name of the entity of the value.</param>
		public DefaultAttribute(string value, string entityName)
		{
			_entityName = entityName;
			_value = value;
		}

		/// <summary>
		/// The name of the entity of the value for an EntityReference.
		/// </summary>
		public string EntityName
		{
			get { return _entityName; }
		}

		/// <summary>
		/// The default value.
		/// </summary>
		public string Value
		{
			get { return _value; }
		}

		private string _value;
		private string _entityName;
	}

	/// <summary>
	/// Base class for custom activity parameter types
	/// <remarks>For Internal use only.</remarks>
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public abstract class ParameterAttribute : Attribute
	{
		protected ParameterAttribute(string name)
		{
			_name = name;
		}

		/// <summary>
		/// The name of the parameter that will appears in the UI.
		/// </summary>
		public string Name
		{
			get { return _name; }
		}

		private string _name;
	}

	/// <summary>
	/// Specify an input parameter.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class InputAttribute : ParameterAttribute
	{
		/// <summary>
		/// Specify an input parameter
		/// </summary>
		/// <param name="name">The name of the parameter that will appears in the UI</param>
		public InputAttribute(string name)
			: base(name)
		{
		}
	}

	/// <summary>
	/// Specifiy an output parameter
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class OutputAttribute : ParameterAttribute
	{
		/// <summary>
		/// Specify an output parameter
		/// </summary>
		/// <param name="name">The name of the parameter that will appears in the UI</param>
		public OutputAttribute(string name)
			: base(name)
		{
		}
	}
}
