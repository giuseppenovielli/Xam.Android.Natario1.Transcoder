using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Resample {

	[Register ("com/otaliastudios/transcoder/resample/AudioResampler", DoNotGenerateAcw=true)]
	public abstract class AudioResampler : Java.Lang.Object {
		internal AudioResampler ()
		{
		}


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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/resample/AudioResampler", typeof (AudioResampler));

	}

	[Register ("com/otaliastudios/transcoder/resample/AudioResampler", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AudioResampler' type. This type will be removed in a future release.", error: true)]
	public abstract class AudioResamplerConsts : AudioResampler {
		private AudioResamplerConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.resample']/interface[@name='AudioResampler']"
	[Register ("com/otaliastudios/transcoder/resample/AudioResampler", "", "Com.Otaliastudios.Transcoder.Resample.IAudioResamplerInvoker")]
	public partial interface IAudioResampler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.resample']/interface[@name='AudioResampler']/method[@name='resample' and count(parameter)=5 and parameter[1][@type='java.nio.ShortBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ShortBuffer'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("resample", "(Ljava/nio/ShortBuffer;ILjava/nio/ShortBuffer;II)V", "GetResample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_IIHandler:Com.Otaliastudios.Transcoder.Resample.IAudioResamplerInvoker, AndroidTranscoderBinding")]
		void Resample (global::Java.Nio.ShortBuffer p0, int p1, global::Java.Nio.ShortBuffer p2, int p3, int p4);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/resample/AudioResampler", DoNotGenerateAcw=true)]
	internal partial class IAudioResamplerInvoker : global::Java.Lang.Object, IAudioResampler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/resample/AudioResampler", typeof (IAudioResamplerInvoker));

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

		public static IAudioResampler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioResampler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.resample.AudioResampler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioResamplerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II;
#pragma warning disable 0169
		static Delegate GetResample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_IIHandler ()
		{
			if (cb_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II == null)
				cb_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILII_V) n_Resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II);
			return cb_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II;
		}

		static void n_Resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Resample (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II;
		public unsafe void Resample (global::Java.Nio.ShortBuffer p0, int p1, global::Java.Nio.ShortBuffer p2, int p3, int p4)
		{
			if (id_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II == IntPtr.Zero)
				id_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II = JNIEnv.GetMethodID (class_ref, "resample", "(Ljava/nio/ShortBuffer;ILjava/nio/ShortBuffer;II)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resample_Ljava_nio_ShortBuffer_ILjava_nio_ShortBuffer_II, __args);
		}

	}
}
