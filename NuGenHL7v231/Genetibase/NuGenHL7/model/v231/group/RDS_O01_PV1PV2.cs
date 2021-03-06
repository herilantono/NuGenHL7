using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RDS_O01_PV1PV2 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PV1 (PV1 - patient visit segment-) <b></b><br>
	/// 1: PV2 (PV2 - patient visit - additional information segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RDS_O01_PV1PV2:AbstractGroup
	{
		/// <summary> Returns PV1 (PV1 - patient visit segment-) - creates it if necessary</summary>
		virtual public PV1 PV1
		{
			get
			{
				PV1 ret = null;
				try
				{
					ret = (PV1) this.get_Renamed("PV1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PV2 (PV2 - patient visit - additional information segment) - creates it if necessary</summary>
		virtual public PV2 PV2
		{
			get
			{
				PV2 ret = null;
				try
				{
					ret = (PV2) this.get_Renamed("PV2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RDS_O01_PV1PV2 Group.</summary>
		public RDS_O01_PV1PV2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PV1), true, false);
				this.add(typeof(PV2), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}