using SoftwarePatterns.Behavioral.Memento.Implementation;
using System.Collections.Generic;

List<MementoObject> savedStates = new();

Originator originator = new();
originator.Set("State1");
originator.Set("State2");
savedStates.Add(originator.SaveToMemento());
originator.Set("State3");

savedStates.Add(originator.SaveToMemento());
originator.Set("State4");

originator.RestoreFromMemento(savedStates[1]);