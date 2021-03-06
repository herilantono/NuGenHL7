using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 ADD message segment. 
	/// This segment has the following fields:</p><p>
	/// ADD-1: Addendum Continuation Pointer (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ADD:AbstractSegment
	{
		/// <summary> Returns Addendum Continuation Pointer (ADD-1).</summary>
		virtual public ST AddendumContinuationPointer
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a ADD (Addendum) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ADD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 65536, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}