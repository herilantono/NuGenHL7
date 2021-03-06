using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the ADT_A08_INSURANCE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: IN1 (INSURANCE) <b></b><br>
	/// 1: IN2 (INSURANCE ADDITIONAL INFO) <b>optional </b><br>
	/// 2: IN3 (INSURANCE ADDITIONAL INFO-CERTIFICATION) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ADT_A08_INSURANCE:AbstractGroup
	{
		/// <summary> Returns IN1 (INSURANCE) - creates it if necessary</summary>
		virtual public IN1 IN1
		{
			get
			{
				IN1 ret = null;
				try
				{
					ret = (IN1) this.get_Renamed("IN1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns IN2 (INSURANCE ADDITIONAL INFO) - creates it if necessary</summary>
		virtual public IN2 IN2
		{
			get
			{
				IN2 ret = null;
				try
				{
					ret = (IN2) this.get_Renamed("IN2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns IN3 (INSURANCE ADDITIONAL INFO-CERTIFICATION) - creates it if necessary</summary>
		virtual public IN3 IN3
		{
			get
			{
				IN3 ret = null;
				try
				{
					ret = (IN3) this.get_Renamed("IN3");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ADT_A08_INSURANCE Group.</summary>
		public ADT_A08_INSURANCE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(IN1), true, false);
				this.add(typeof(IN2), false, false);
				this.add(typeof(IN3), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}