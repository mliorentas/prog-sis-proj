﻿using DigitalAudioWorkstation.Domain.Factories;
using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Services.AudioServices
{
    class AudioTrackService : ITrackService
    {
        ITrackFactory m_factory;
        ITrackStore m_trackStore;
        IClipStore m_clipStore;

        public AudioTrackService(ITrackFactory factory, ITrackStore trackStore, IClipStore clipStore)
        {
            m_factory = factory;
            m_trackStore = trackStore;
            m_clipStore = clipStore;
        }

        public IClip CreateClip(string id)
        {
            var clip = m_factory.CreateClip(id);
            return m_clipStore.AddOrReplaceClip(clip);
        }

        public ITrack CreateTrack(string id)
        {
            var track = m_factory.CreateTrack(id);
            return m_trackStore.AddOrReplaceTrack(track);
        }

        public IClip GetClip(string id)
        {
            return m_clipStore.GetClip(id);
        }

        public ITrack GetTrack(string id)
        {
            return m_trackStore.GetTrack(id);
        }

        public void AddClip(ITrack track, IClip clip)
        {
            track.Clips.Add(clip);
        }

        public void AddEffect(string trackId, string data)
        {
            var track = m_trackStore.GetTrack(trackId);
            if (null == track)
                return;

            track.TrackInfo = track.TrackInfo + "Effect: " + data;
        }

        public void AddRecording(string clipId, string data)
        {
            var clip = m_clipStore.GetClip(clipId);
            if (null == clip)
                return;

            clip.Data = clip.Data + ", Recording data: " + data;
        }

        public string GetTrackData(string id)
        {
            var track = m_trackStore.GetTrack(id);
            if (null == track)
                return String.Empty;

            return track.TrackInfo;
        }
    }
}
