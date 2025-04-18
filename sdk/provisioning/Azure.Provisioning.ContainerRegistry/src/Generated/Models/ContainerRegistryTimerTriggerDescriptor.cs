// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The ContainerRegistryTimerTriggerDescriptor.
/// </summary>
public partial class ContainerRegistryTimerTriggerDescriptor : ProvisionableConstruct
{
    /// <summary>
    /// The timer trigger name that caused the run.
    /// </summary>
    public BicepValue<string> TimerTriggerName 
    {
        get { Initialize(); return _timerTriggerName!; }
        set { Initialize(); _timerTriggerName!.Assign(value); }
    }
    private BicepValue<string>? _timerTriggerName;

    /// <summary>
    /// The occurrence that triggered the run.
    /// </summary>
    public BicepValue<string> ScheduleOccurrence 
    {
        get { Initialize(); return _scheduleOccurrence!; }
        set { Initialize(); _scheduleOccurrence!.Assign(value); }
    }
    private BicepValue<string>? _scheduleOccurrence;

    /// <summary>
    /// Creates a new ContainerRegistryTimerTriggerDescriptor.
    /// </summary>
    public ContainerRegistryTimerTriggerDescriptor()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerRegistryTimerTriggerDescriptor.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _timerTriggerName = DefineProperty<string>("TimerTriggerName", ["timerTriggerName"]);
        _scheduleOccurrence = DefineProperty<string>("ScheduleOccurrence", ["scheduleOccurrence"]);
    }
}
