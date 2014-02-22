﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="hb_audio.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Defines the hb_audio_s type.
// </summary>
// <auto-generated> Disable Stylecop Warnings for this file  </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.HbLib
{
	using System;
	using System.Runtime.InteropServices;

	using HandBrake.Interop.Helpers;

    [StructLayout(LayoutKind.Sequential)]
	public struct hb_audio_s
	{
		/// int
		public int id;

		/// hb_audio_config_t->hb_audio_config_s
		public hb_audio_config_s config;

		// Padding for the part of the struct we don't care about marshaling.
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MarshalingConstants.AudioPaddingBytes, ArraySubType = UnmanagedType.U1)]
		public byte[] padding;

		// Anonymous_e6c7b779_b5a3_4e80_9fa8_13619d14f545
		// public Anonymous_e6c7b779_b5a3_4e80_9fa8_13619d14f545 priv;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct hb_audio_config_s
	{
		public hb_audio_config_output_s output;
		public hb_audio_config_input_s input;

		public hb_audio_config_lang_s lang;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct hb_audio_config_output_s
	{
		public int mixdown;

		/// int
		public int track;

		/// uint32_t->unsigned int
		public uint codec;

		/// int
		public int samplerate;

		public int samples_per_frame;

		/// int
		public int bitrate;

		public float quality;

		public float compression_level;

		/// double
		public double dynamic_range_compression;

		public double gain;

		public int normalize_mix_level;

		public int dither_method;

		public IntPtr name;

		public int delay;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct hb_audio_config_input_s
	{
		/// int
		public int track;

		/* Input audio codec */
		public uint codec;

		/* Per-codec config info */
		public uint codec_param;

		/* Registration descriptor of source */
		public uint reg_desc;

		/* Stream type from source stream */
		public uint stream_type;

		/* Substream type for multiplexed streams */
		public uint substream_type;

		/* Bitsream version */
		public uint version;

		/* Bitstream flags, codec-specific */
		public uint flags;

		/* Bitstream mode, codec-specific */
		public uint mode;

		/* Input sample rate (Hz) */
		public int samplerate;

		/* Number of samples per frame */
		public int samples_per_frame;

		/* Input bitrate (bps) */
		public int bitrate;

		/* Source matrix encoding mode, set by the audio decoder */
		public int matrix_encoding;

		/* Source channel layout, set by the audio decoder */
		public ulong channel_layout;

		/* Source channel map, set by the audio decoder */
		// hb_chan_map_t
		public IntPtr channel_map;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct hb_audio_config_lang_s
	{
		/// char[1024]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string description;

		/// char[1024]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string simple;

		/// char[4]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public string iso639_2;

		/// uint8_t->unsigned char
		public byte type;
	}
}
