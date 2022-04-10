using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/otaliastudios/transcoder/internal/utils",
						"com/otaliastudios/transcoder/source",
						"com/otaliastudios/transcoder",
					},
					new Converter<string, Type>[]{
						lookup_com_otaliastudios_transcoder_internal_utils_package,
						lookup_com_otaliastudios_transcoder_source_package,
						lookup_com_otaliastudios_transcoder_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_otaliastudios_transcoder_internal_utils_mappings;
		static Type lookup_com_otaliastudios_transcoder_internal_utils_package (string klass)
		{
			if (package_com_otaliastudios_transcoder_internal_utils_mappings == null) {
				package_com_otaliastudios_transcoder_internal_utils_mappings = new string[]{
					"com/otaliastudios/transcoder/internal/utils/MutableTrackMap$DefaultImpls:Com.Otaliastudios.Transcoder.Internal.Utils.MutableTrackMapDefaultImpls",
					"com/otaliastudios/transcoder/internal/utils/TrackMap$DefaultImpls:Com.Otaliastudios.Transcoder.Internal.Utils.TrackMapDefaultImpls",
				};
			}

			return Lookup (package_com_otaliastudios_transcoder_internal_utils_mappings, klass);
		}

		static string[] package_com_otaliastudios_transcoder_source_mappings;
		static Type lookup_com_otaliastudios_transcoder_source_package (string klass)
		{
			if (package_com_otaliastudios_transcoder_source_mappings == null) {
				package_com_otaliastudios_transcoder_source_mappings = new string[]{
					"com/otaliastudios/transcoder/source/DataSource$Chunk:Com.Otaliastudios.Transcoder.Source.DataSourceChunk",
				};
			}

			return Lookup (package_com_otaliastudios_transcoder_source_mappings, klass);
		}

		static string[] package_com_otaliastudios_transcoder_mappings;
		static Type lookup_com_otaliastudios_transcoder_package (string klass)
		{
			if (package_com_otaliastudios_transcoder_mappings == null) {
				package_com_otaliastudios_transcoder_mappings = new string[]{
					"com/otaliastudios/transcoder/ThumbnailerListener$DefaultImpls:Com.Otaliastudios.Transcoder.ThumbnailerListenerDefaultImpls",
				};
			}

			return Lookup (package_com_otaliastudios_transcoder_mappings, klass);
		}
	}
}
