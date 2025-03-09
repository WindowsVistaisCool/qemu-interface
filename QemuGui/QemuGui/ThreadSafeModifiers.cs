﻿using System.Collections.Immutable;

namespace QEMUInterface
{
    public interface IThreadSafeModification
    {
        public void ApplyUnsafe();

        public void Apply();
    }

    /**
     * Represents a thread-safe modification for a control T
     * Inherits IThreadSafeModification
     */
    public readonly struct ThreadSafeModification<T>(T control, Action<T> modifier) : IThreadSafeModification where T : Control
    {
        public readonly T Control = control;
        public readonly Action<T> Modifier = modifier;

        public void ApplyUnsafe() => Modifier(Control);

        public void Apply()
        {
            if (Control.InvokeRequired)
            {
                Control.Invoke((MethodInvoker)Apply);
            }
            else
            {
                // now use ModifyUnsafe now that we are safe
                ApplyUnsafe();
            }
        }
    }

    public readonly struct TSMCollection(IEnumerable<IThreadSafeModification> modifications) : IThreadSafeModification
    {
        public readonly IEnumerable<IThreadSafeModification> Modifications = modifications;

        public void ApplyUnsafe() => Modifications.ToImmutableList().ForEach((m) => m.ApplyUnsafe());

        public void Apply() => Modifications.ToImmutableList().ForEach((m) => m.Apply());
    }

    /**
     * Thread-Safe predefined modifications for generic controls
     */
    public static class TSMPresets
    {
        public static ThreadSafeModification<Control> SetVisible(Control control, bool visible) => new(control, (c) => c.Visible = visible);
        public static ThreadSafeModification<Control> SetEnabled(Control control, bool enabled) => new(control, (c) => c.Enabled = enabled);
    }
}
