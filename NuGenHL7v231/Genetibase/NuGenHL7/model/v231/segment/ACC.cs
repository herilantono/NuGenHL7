using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 ACC message segment. 
	/// This segment has the following fields:</p><p>
	/// ACC-1: Accident Date/Time (TS)<br> 
	/// ACC-2: Accident Code (CE)<br> 
	/// ACC-3: Accident Location (ST)<br> 
	/// ACC-4: Auto Accident State (CE)<br> 
	/// ACC-5: Accident Job Related Indicator (ID)<br> 
	/// ACC-6: Accident Death Indicator (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ACC:AbstractSegment
	{
		/// <summary> Returns Accident Date/Time (ACC-1).</summary>
		virtual public TS AccidentDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (TS) t;
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
		/// <summary> Returns Accident Code (ACC-2).</summary>
		virtual public CE AccidentCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CE) t;
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
		/// <summary> Returns Accident Location (ACC-3).</summary>
		virtual public ST AccidentLocation
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Auto Accident State (ACC-4).</summary>
		virtual public CE AutoAccidentState
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (CE) t;
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
		/// <summary> Returns Accident Job Related Indicator (ACC-5).</summary>
		virtual public ID AccidentJobRelatedIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (ID) t;
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
		/// <summary> Returns Accident Death Indicator (ACC-6).</summary>
		virtual public ID AccidentDeathIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (ID) t;
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
		
		/// <summary> Creates a ACC (ACC - accident segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ACC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 12, new System.Object[]{message, 136});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}