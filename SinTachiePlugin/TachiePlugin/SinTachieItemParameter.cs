﻿using SinTachiePlugin.Parts;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using YukkuriMovieMaker.Commons;
using YukkuriMovieMaker.Plugin.Tachie;

namespace SinTachiePlugin.Parts
{
    internal class SinTachieItemParameter : TachieItemParameterBase
    {
        [Display(Name = "描画順序", Description = "描画順序")]
        [PartsListController(PropertyEditorSize = PropertyEditorSize.FullWidth)]
        public ImmutableList<PartBlock> Parts { get => parts; set => Set(ref parts, value); }
        ImmutableList<PartBlock> parts = [];
        
        /// <summary>
        /// クラス内のIAnimatableを列挙する。
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<IAnimatable> GetAnimatables() => Parts;
    }
}
