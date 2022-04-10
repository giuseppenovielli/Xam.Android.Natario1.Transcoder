using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Resample {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.resample']/class[@name='PassThroughAudioResampler']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/resample/PassThroughAudioResampler", DoNotGenerateAcw=true)]
	public partial class PassThroughAudioResampler : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler {
		public static class InterfaceConsts {
			// The following are fields from: com.otaliastudios.transcoder.resample.AudioResampler


			// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.resample']/interface[@name='AudioResampler']/field[@name='DOWNSAMPLE']"
			[Register ("DOWNSAMPLE")]
			public static global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler Downsample {
				get {
					const string __id = "DOWNSAMPLE.Lcom/otaliastudios/transcoder/resample/AudioResampler;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.resample']/interface[@name='AudioResampler']/field[@name='PASSTHROUGH']"
			[Register ("PASSTHROUGH")]
			public static global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler Passthrough {
				get {
					const string __id = "PASSTHROUGH.Lcom/otaliastudios/transcoder/resample/AudioResampler;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.resample']/interface[@name='AudioResampler']/field[@name='UPSAMPLE']"
			[Register ("UPSAMPLE")]
			public static global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler Upsample {
				get {
					const string __id = "UPSAMPLE.Lcom/otaliastudios/transcoder/resample/AudioResampler;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/resample/PassThroughAudioResampler", typeof (PassThroughAudioResampler));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected PassThroughAudioResampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.resample']/class[@name='PassThroughAudioResampler']/constructor[@name='PassThroughAudioResampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PassThroughAudioResampler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II;
#pragma warning disable 0169
		static Delegate GetResample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_IIHandler ()
		{
			if (cb_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II == null)
				cb_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILII_V) n_Resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II);
			return cb_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II;
		}

		static void n_Resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_inputBuffer, int inputSampleRate, IntPtr native_outputBuffer, int outputSampleRate, int channels)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resample.PassThroughAudioResampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_inputBuffer, JniHandleOwnership.DoNotTransfer);
			var outputBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_outputBuffer, JniHandleOwnership.DoNotTransfer);
			__this.Resample (inputBuffer, inputSampleRate, outputBuffer, outputSampleRate, channels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.resample']/class[@name='PassThroughAudioResampler']/method[@name='resample' and count(parameter)=5 and parameter[1][@type='java.nio.ShortBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ShortBuffer'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("resample", "(Ljava/nio/ShortBuffer;ILjava/nio/ShortBuffer;II)V", "GetResample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_IIHandler")]
		public virtual unsafe void Resample (global::Java.Nio.ShortBuffer inputBuffer, int inputSampleRate, global::Java.Nio.ShortBuffer outputBuffer, int outputSampleRate, int channels)
		{
			const string __id = "resample.(Ljava/nio/ShortBuffer;ILjava/nio/ShortBuffer;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((inputBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputBuffer).Handle);
				__args [1] = new JniArgumentValue (inputSampleRate);
				__args [2] = new JniArgumentValue ((outputBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputBuffer).Handle);
				__args [3] = new JniArgumentValue (outputSampleRate);
				__args [4] = new JniArgumentValue (channels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (inputBuffer);
				global::System.GC.KeepAlive (outputBuffer);
			}
		}

	}
}
