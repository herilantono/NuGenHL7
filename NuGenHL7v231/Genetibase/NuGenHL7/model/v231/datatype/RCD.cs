using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 RCD (row column definition) data type.  Consists of the following components: </p><ol>
	/// <li>segment field name (ST)</li>
	/// <li>HL7 date type (ST)</li>
	/// <li>maximum column width (NM)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class RCD:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns segment field name (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST SegmentFieldName
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns HL7 date type (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST HL7DateType
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns maximum column width (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM MaximumColumnWidth
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a RCD.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public RCD(Message message):base(message)
		{
			data = new Type[3];
			data[0] = new ST(message);
			data[1] = new ST(message);
			data[2] = new NM(message);
		}
		
		/// <summary> Returns an individual data component.</summary>
		/// <throws>  DataTypeException if the given element number is out of range. </throws>
		public virtual Type getComponent(int number)
		{
			
			try
			{
				return this.data[number];
			}
			catch (IndexOutOfRangeException)
			{
				throw new DataTypeException("Element " + number + " doesn't exist in 3 element RCD composite");
			}
		}
	}
}