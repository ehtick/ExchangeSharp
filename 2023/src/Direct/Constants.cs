namespace TS3D.Exchange.Direct
{
    public class Constants
    {
        public static uint A3D_DEFAULT_COLOR_INDEX = uint.MaxValue;
        public static ushort A3D_DEFAULT_LAYER = ushort.MaxValue;
        public static uint A3D_DEFAULT_LINEPATTERN_INDEX = uint.MaxValue;
        public static double A3D_DEFAULT_LINE_WIDTH = 0.1;
        public static uint A3D_DEFAULT_MATERIAL_INDEX = uint.MaxValue;
        public static ushort A3D_DEFAULT_NO_UNIT = ushort.MaxValue;
        public static uint A3D_DEFAULT_PATTERN_INDEX = uint.MaxValue;
        public static uint A3D_DEFAULT_PICTURE_INDEX = uint.MaxValue;
        public static ushort A3D_DEFAULT_STYLE_INDEX = ushort.MaxValue;
        public static uint A3D_DEFAULT_TEXTURE_APPLICATION_INDEX = uint.MaxValue;
        public static uint A3D_DEFAULT_TEXTURE_DEFINITION_INDEX = uint.MaxValue;
        public static byte A3D_DEFAULT_TRANSPARENCY = byte.MaxValue;
        public static int A3D_DLL_MAJORVERSION = 23;
        public static int A3D_DLL_MINORVERSION = 0;
        public static int A3D_HLR_TYPE_EDGE = 1;
        public static int A3D_HLR_TYPE_SECTION = 3;
        public static int A3D_HLR_TYPE_SILHOUETTE = 2;
        public static int A3D_HLR_TYPE_SILHOUETTE_SECTION = 4;
        public static int A3D_HLR_TYPE_UNKNOWN = 0;
        public static uint A3D_LOOP_UNKNOWN_OUTER_INDEX = uint.MaxValue;
        public static int A3D_MAX_BUFFER = 2048;
        public static int A3D_PRODUCT_FLAG_BIM_BUILDING = 0x10000;
        public static int A3D_PRODUCT_FLAG_BIM_CATEGORY = 0x40000;
        public static int A3D_PRODUCT_FLAG_BIM_COMPONENT = 0x80000;
        public static int A3D_PRODUCT_FLAG_BIM_LEVEL = 0x20000;
        public static int A3D_PRODUCT_FLAG_BIM_PROJECT = 0x4000;
        public static int A3D_PRODUCT_FLAG_BIM_SITE = 0x8000;
        public static int A3D_PRODUCT_FLAG_CONFIG = 0x0008;
        public static int A3D_PRODUCT_FLAG_CONFIG_NOT_UPDATED = 0x0100;
        public static int A3D_PRODUCT_FLAG_CONTAINER = 0x0004;
        public static int A3D_PRODUCT_FLAG_DEFAULT = 0x0001;
        public static int A3D_PRODUCT_FLAG_EXTERNAL_REFERENCE = 0x2000;
        public static int A3D_PRODUCT_FLAG_INTERNAL = 0x0002;
        public static int A3D_PRODUCT_FLAG_SUPPRESSED = 0x0040;
        public static int A3D_PRODUCT_FLAG_VIEW = 0x0010;
        public static int kA3DBodyBoundingBoxCadData = 0x0003;
        public static int kA3DBodyBoundingBoxEvaluation = 0x0001;
        public static int kA3DBodyBoundingBoxPrecise = 0x0002;
        public static int kA3DContextHasAnalytics = 0x0008;
        public static int kA3DContextNoClamp = 0x0002;
        public static int kA3DContextNoSplit = 0x0004;
        public static int kA3DContextOuterLoopFirst = 0x0001;
        public static int kA3DDraw3D = 0x1;
        public static int kA3DDrawMarkups = 0x2;
        public static int kA3DFontBold = 0x02;
        public static int kA3DFontFixedWidth = 0x100;
        public static int kA3DFontItalic = 0x04;
        public static int kA3DFontKeyAttrib = 0x00000FFF;
        public static int kA3DFontKeySize = 0x00FFF000;
        public static uint kA3DFontKeyStyle = 0xFF000000;
        public static int kA3DFontOverlined = 0x20;
        public static int kA3DFontStreched = 0x40;
        public static int kA3DFontStrikedOut = 0x10;
        public static int kA3DFontUnderlined = 0x08;
        public static int kA3DFontWired = 0x80;
        public static int kA3DGraphicsFatherHeritColor = 0x0010;
        public static int kA3DGraphicsFatherHeritLayer = 0x0040;
        public static int kA3DGraphicsFatherHeritLinePattern = 0x0400;
        public static int kA3DGraphicsFatherHeritLineWidth = 0x1000;
        public static int kA3DGraphicsFatherHeritShow = 0x0004;
        public static int kA3DGraphicsFatherHeritTransparency = 0x0100;
        public static int kA3DGraphicsRemoved = 0x2000;
        public static int kA3DGraphicsShow = 0x0001;
        public static int kA3DGraphicsSonHeritColor = 0x0008;
        public static int kA3DGraphicsSonHeritLayer = 0x0020;
        public static int kA3DGraphicsSonHeritLinePattern = 0x0200;
        public static int kA3DGraphicsSonHeritLineWidth = 0x0800;
        public static int kA3DGraphicsSonHeritShow = 0x0002;
        public static int kA3DGraphicsSonHeritTransparency = 0x0080;
        public static int kA3DMDTrailingToleranceConsistentDigitsMask = 0b100;
        public static int kA3DMarkupColorMask = 0x1600000;
        public static int kA3DMarkupCylinderMask = 0x1400000;
        public static int kA3DMarkupExtraDataType = 0x03E00000;
        public static int kA3DMarkupFaceViewMask = 0x0C00000;
        public static int kA3DMarkupFixedSizeMask = 0x1000000;
        public static int kA3DMarkupFontMask = 0x1A00000;
        public static int kA3DMarkupFrameDrawMask = 0x0E00000;
        public static int kA3DMarkupHasFrame = 0x02;
        public static int kA3DMarkupIntegerMask = 0x000FFFFF;
        public static int kA3DMarkupIsExtraData = 0x04000000;
        public static int kA3DMarkupIsHidden = 0x01;
        public static int kA3DMarkupIsMatrix = 0x08000000;
        public static int kA3DMarkupIsNotModifiable = 0x04;
        public static int kA3DMarkupIsNotRotatable = 0x20;
        public static int kA3DMarkupIsOnTop = 0x10;
        public static int kA3DMarkupIsZoomable = 0x08;
        public static int kA3DMarkupLineStippleMask = 0x1800000;
        public static int kA3DMarkupLineWidthMask = 0x2200000;
        public static int kA3DMarkupPatternMask = 0x0000000;
        public static int kA3DMarkupPictureMask = 0x0200000;
        public static int kA3DMarkupPointsMask = 0x1E00000;
        public static int kA3DMarkupPolygonMask = 0x2000000;
        public static int kA3DMarkupQuadsMask = 0x0600000;
        public static int kA3DMarkupSymbolMask = 0x1200000;
        public static int kA3DMarkupTextMask = 0x1C00000;
        public static int kA3DMarkupTrianglesMask = 0x0400000;
        public static int kA3DNoActiveSheet = ~0;
        public static string kA3DPBRAttributeNameAlphaCutOff = "AlphaCutOff";
        public static string kA3DPBRAttributeNameAlphaMode = "AlphaMode";
        public static string kA3DPBRAttributeNameMetallicFactor = "MetallicFactor";
        public static string kA3DPBRAttributeNameNormalTextureFactor = "NormalTextureFactor";
        public static string kA3DPBRAttributeNameOcclusionTextureFactor = "OcclusionTextureFactor";
        public static string kA3DPBRAttributeNameRoughnessFactor = "RoughnessFactor";
        public static string kA3DRhinoAttributeName3DMVersion = "3DM version";
        public static string kA3DRhinoAttributeNameApplicationUUID = "application UUID";
        public static string kA3DRhinoAttributeNameArchiveClassUUID = "archive class UUID";
        public static string kA3DRhinoAttributeNameBufferData = "buffer data";
        public static string kA3DRhinoAttributeNameDocumentUserStrings = "document user strings";
        public static string kA3DRhinoAttributeNameModelObjectUUID = "model object UUID";
        public static string kA3DRhinoAttributeNameOpenNURBSVersion = "OpenNURBS version number";
        public static string kA3DRhinoAttributeNameRDKMaterialInstanceUUID = "RDK material instance UUID";
        public static string kA3DRhinoAttributeNameUnknownClassUUID = "unknown class UUID";
        public static string kA3DRhinoAttributeNameUserDataCopyCount = "user data copy count";
        public static string kA3DRhinoAttributeNameUserDataUUID = "user data UUID";
        public static string kA3DRhinoAttributeNameUserDataXForm = "user data xform";
        public static int kA3DTess3DWireDataIsClosing = 0x10000000;
        public static int kA3DTess3DWireDataIsContinuous = 0x20000000;
        public static int kA3DTessFaceDataNormalMask = 0x3FFFFFFF;
        public static int kA3DTessFaceDataNormalSingle = 0x40000000;
        public static int kA3DTessFaceDataPolyface = 0x0001;
        public static int kA3DTessFaceDataPolyfaceOneNormal = 0x0010;
        public static int kA3DTessFaceDataPolyfaceOneNormalTextured = 0x1000;
        public static int kA3DTessFaceDataPolyfaceTextured = 0x0100;
        public static int kA3DTessFaceDataTriangle = 0x0002;
        public static int kA3DTessFaceDataTriangleFan = 0x0004;
        public static int kA3DTessFaceDataTriangleFanOneNormal = 0x0040;
        public static int kA3DTessFaceDataTriangleFanOneNormalTextured = 0x4000;
        public static int kA3DTessFaceDataTriangleFanTextured = 0x0400;
        public static int kA3DTessFaceDataTriangleOneNormal = 0x0020;
        public static int kA3DTessFaceDataTriangleOneNormalTextured = 0x2000;
        public static int kA3DTessFaceDataTriangleStripe = 0x0008;
        public static int kA3DTessFaceDataTriangleStripeOneNormal = 0x0080;
        public static int kA3DTessFaceDataTriangleStripeOneNormalTextured = 0x8000;
        public static int kA3DTessFaceDataTriangleStripeTextured = 0x0800;
        public static int kA3DTessFaceDataTriangleTextured = 0x0200;
        public static int kA3DTessFaceDataWireIsClosing = 0x8000;
        public static int kA3DTessFaceDataWireIsNotDrawn = 0x4000;
        public static int kA3DTextureApplyingModeAlphaTest = 0x0002;
        public static int kA3DTextureApplyingModeLighting = 0x0001;
        public static int kA3DTextureApplyingModeNone = 0x0000;
        public static int kA3DTextureApplyingModeVertexColor = 0x0004;
        public static int kA3DTextureMappingAmbient = 0x0080;
        public static int kA3DTextureMappingBump = 0x0002;
        public static int kA3DTextureMappingClearcoat = 0x8000;
        public static int kA3DTextureMappingClearcoatNormal = kA3DTextureMappingClearcoat | kA3DTextureMappingNormal;
        public static int kA3DTextureMappingClearcoatRoughness = kA3DTextureMappingClearcoat | kA3DTextureMappingRoughness;
        public static int kA3DTextureMappingComponentsAlpha = 0x0008;
        public static int kA3DTextureMappingComponentsBlue = 0x0004;
        public static int kA3DTextureMappingComponentsGreen = 0x0002;
        public static int kA3DTextureMappingComponentsRed = 0x0001;
        public static int kA3DTextureMappingComponentsRgb = 0x0007;
        public static int kA3DTextureMappingComponentsRgba = 0x000f;
        public static int kA3DTextureMappingCubicalReflection = 0x0010;
        public static int kA3DTextureMappingDiffuse = 0x0001;
        public static int kA3DTextureMappingDiffuseGlossiness = kA3DTextureMappingDiffuse | kA3DTextureMappingGlossiness;
        public static int kA3DTextureMappingEmission = 0x0100;
        public static int kA3DTextureMappingGlossiness = 0x2000;
        public static int kA3DTextureMappingMetalness = 0x0400;
        public static int kA3DTextureMappingMetalnessRoughness = kA3DTextureMappingMetalness | kA3DTextureMappingRoughness;
        public static int kA3DTextureMappingMetalnessRoughnessOcclusion = kA3DTextureMappingMetalnessRoughness | kA3DTextureMappingOcclusion;
        public static int kA3DTextureMappingNormal = 0x0200;
        public static int kA3DTextureMappingOcclusion = 0x1000;
        public static int kA3DTextureMappingOpacity = 0x0004;
        public static int kA3DTextureMappingRefraction = 0x0020;
        public static int kA3DTextureMappingRoughness = 0x0800;
        public static int kA3DTextureMappingSpecular = 0x0040;
        public static int kA3DTextureMappingSpecularColor = 0x4000;
        public static int kA3DTextureMappingSpecularGlossiness = kA3DTextureMappingSpecular | kA3DTextureMappingGlossiness;
        public static int kA3DTextureMappingSphericalReflection = 0x0008;
        public static int kA3DTransformationIdentity = 0x00;
        public static int kA3DTransformationMirror = 0x04;
        public static int kA3DTransformationNonUniformScale = 0x10;
        public static int kA3DTransformationRotate = 0x02;
        public static int kA3DTransformationScale = 0x08;
        public static int kA3DTransformationTranslate = 0x01;
    }
}
