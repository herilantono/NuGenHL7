using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 DLT (delta check) data type.  Consists of the following components: </p><ol>
	/// <li>Range (NR)</li>
	/// <li>numeric threshold (NM)</li>
	/// <li>change computation (ST)</li>
	/// <li>length of time-days (NM)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class DLT:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Range (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NR Range
		{
			get
			{
				NR ret = null;
				try
				{
					ret = (NR) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns numeric threshold (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM NumericThreshold
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns change computation (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST ChangeComputation
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns length of time-days (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM LengthOfTimeDays
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a DLT.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public DLT(Message message):base(message)
		{
			data = new Type[4];
			data[0] = new NR(message);
			data[1] = new NM(message);
			data[2] = new ST(message);
			data[3] = new NM(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 4 element DLT composite");
			}
		}
	}
}