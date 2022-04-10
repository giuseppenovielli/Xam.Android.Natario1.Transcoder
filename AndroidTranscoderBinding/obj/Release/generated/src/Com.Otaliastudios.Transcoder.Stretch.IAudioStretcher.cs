using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Stretch {

	[Register ("com/otaliastudios/transcoder/stretch/AudioStretcher", DoNotGenerateAcw=true)]
	public abstract class AudioStretcher : Java.Lang.Object {
		internal AudioStretcher ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/interface[@name='AudioStretcher']/field[@name='CUT']"
		[Register ("CUT")]
		public static global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher Cut {
			get {
				const string __id = "CUT.Lcom/otaliastudios/transcoder/stretch/AudioStretcher;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/interface[@name='AudioStretcher']/field[@name='INSERT']"
		[Register ("INSERT")]
		public static global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher Insert {
			get {
				const string __id = "INSERT.Lcom/otaliastudios/transcoder/stretch/AudioStretcher;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/interface[@name='AudioStretcher']/field[@name='PASSTHROUGH']"
		[Register ("PASSTHROUGH")]
		public static global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher Passthrough {
			get {
				const string __id = "PASSTHROUGH.Lcom/otaliastudios/transcoder/stretch/AudioStretcher;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/stretch/AudioStretcher", typeof (AudioStretcher));

	}

	[Register ("com/otaliastudios/transcoder/stretch/AudioStretcher", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AudioStretcher' type. This type will be removed in a future release.", error: true)]
	public abstract class AudioStretcherConsts : AudioStretcher {
		private AudioStretcherConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/interface[@name='AudioStretcher']"
	[Register ("com/otaliastudios/transcoder/stretch/AudioStretcher", "", "Com.Otaliastudios.Transcoder.Stretch.IAudioStretcherInvoker")]
	public partial interface IAudioStretcher : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/interface[@name='AudioStretcher']/method[@name='stretch' and count(parameter)=3 and parameter[1][@type='java.nio.ShortBuffer'] and parameter[2][@type='java.nio.ShortBuffer'] and parameter[3][@type='int']]"
		[Register ("stretch", "(Ljava/nio/ShortBuffer;Ljava/nio/ShortBuffer;I)V", "GetStretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_IHandler:Com.Otaliastudios.Transcoder.Stretch.IAudioStretcherInvoker, AndroidTranscoderBinding")]
		void Stretch (global::Java.Nio.ShortBuffer p0, global::Java.Nio.ShortBuffer p1, int p2);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/stretch/AudioStretcher", DoNotGenerateAcw=true)]
	internal partial class IAudioStretcherInvoker : global::Java.Lang.Object, IAudioStretcher {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/stretch/AudioStretcher", typeof (IAudioStretcherInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAudioStretcher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioStretcher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.stretch.AudioStretcher'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioStretcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I;
#pragma warning disable 0169
		static Delegate GetStretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_IHandler ()
		{
			if (cb_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I == null)
				cb_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I);
			return cb_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I;
		}

		static void n_Stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Stretch (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I;
		public unsafe void Stretch (global::Java.Nio.ShortBuffer p0, global::Java.Nio.ShortBuffer p1, int p2)
		{
			if (id_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I == IntPtr.Zero)
				id_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I = JNIEnv.GetMethodID (class_ref, "stretch", "(Ljava/nio/ShortBuffer;Ljava/nio/ShortBuffer;I)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I, __args);
		}

	}
}
