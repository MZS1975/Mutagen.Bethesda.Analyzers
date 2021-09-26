﻿using Mutagen.Bethesda.Analyzers.SDK.Analyzers;
using Mutagen.Bethesda.Analyzers.SDK.Errors;
using Mutagen.Bethesda.Analyzers.SDK.Results;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.Analyzers.Skyrim
{
    public partial class MissingAssetsAnalyzer : IRecordAnalyzer<ITextureSetGetter>
    {
        public static readonly ErrorDefinition<string, string?> MissingTextureInTextureSet = new(
            "SOMEID",
            "Missing Texture in TextureSet",
            "Missing texture {0} at {1}",
            Severity.Error);

        private const string TextureSetDiffuseName = nameof(ITextureSet.Diffuse);
        private const string TextureSetNormalOrGlossName = "Normal/Gloss";
        private const string TextureSetEnvironmentMaskOrSubsurfaceTintName = "Environment Maks/Subsurface Tint";
        private const string TextureSetGlowOrDetailMapName = "Glow/Detail Map";
        private const string TextureSetHeightName = nameof(ITextureSet.Height);
        private const string TextureSetEnvironmentName = nameof(ITextureSet.Environment);
        private const string TextureSetMultilayerName = nameof(ITextureSet.Multilayer);
        private const string TextureSetBacklightMaskOrSpecularName = "Backlight Mask/Specular";

        public MajorRecordAnalyzerResult AnalyzeRecord(IRecordAnalyzerParams<ITextureSetGetter> param)
        {
            var result = new MajorRecordAnalyzerResult();

            CheckForMissingAsset(param.Record.Diffuse, result, () => RecordError.Create(param.Record, MissingTextureInTextureSet.Format(TextureSetDiffuseName, param.Record.Diffuse), x => x.Diffuse!));
            CheckForMissingAsset(param.Record.NormalOrGloss, result, () => RecordError.Create(param.Record, MissingTextureInTextureSet.Format(TextureSetNormalOrGlossName, param.Record.NormalOrGloss), x => x.NormalOrGloss!));
            CheckForMissingAsset(param.Record.EnvironmentMaskOrSubsurfaceTint, result, () => RecordError.Create(param.Record, MissingTextureInTextureSet.Format(TextureSetEnvironmentMaskOrSubsurfaceTintName, param.Record.EnvironmentMaskOrSubsurfaceTint), x => x.EnvironmentMaskOrSubsurfaceTint!));
            CheckForMissingAsset(param.Record.GlowOrDetailMap, result, () => RecordError.Create(param.Record, MissingTextureInTextureSet.Format(TextureSetGlowOrDetailMapName, param.Record.GlowOrDetailMap), x => x.GlowOrDetailMap!));
            CheckForMissingAsset(param.Record.Height, result, () => RecordError.Create(param.Record, MissingTextureInTextureSet.Format(TextureSetHeightName, param.Record.Height), x => x.Height!));
            CheckForMissingAsset(param.Record.Environment, result, () => RecordError.Create(param.Record, MissingTextureInTextureSet.Format(TextureSetEnvironmentName, param.Record.Environment), x => x.Environment!));
            CheckForMissingAsset(param.Record.Multilayer, result, () => RecordError.Create(param.Record, MissingTextureInTextureSet.Format(TextureSetMultilayerName, param.Record.Multilayer), x => x.Multilayer!));
            CheckForMissingAsset(param.Record.BacklightMaskOrSpecular, result, () => RecordError.Create(param.Record, MissingTextureInTextureSet.Format(TextureSetBacklightMaskOrSpecularName, param.Record.BacklightMaskOrSpecular), x => x.BacklightMaskOrSpecular!));

            return result;
        }
    }
}
