using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SRDebugger.Internal;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IOptionsService))]
	public class OptionsServiceImpl : IOptionsService
	{
		private readonly Dictionary<object, ICollection<OptionDefinition>> _optionContainerLookup;

		private readonly List<OptionDefinition> _options;

		private readonly IList<OptionDefinition> _optionsReadonly;

		public ICollection<OptionDefinition> Options => null;

		public event EventHandler OptionsUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<PropertyChangedEventArgs> OptionsValueUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Scan(object obj)
		{
		}

		public void AddContainer(object obj)
		{
		}

		public void RemoveContainer(object obj)
		{
		}

		private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		private void OnSROptionsPropertyChanged(object sender, string propertyName)
		{
		}

		private void OnOptionsUpdated()
		{
		}
	}
}
