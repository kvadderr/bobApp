; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [242 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 79
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 97
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 36
	i32 101534019, ; 3: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 88
	i32 120558881, ; 4: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 88
	i32 134690465, ; 5: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 101
	i32 165246403, ; 6: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 65
	i32 182336117, ; 7: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 89
	i32 209399409, ; 8: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 63
	i32 230216969, ; 9: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 75
	i32 230752869, ; 10: Microsoft.CSharp.dll => 0xdc10265 => 6
	i32 232815796, ; 11: System.Web.Services => 0xde07cb4 => 118
	i32 278686392, ; 12: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 78
	i32 280482487, ; 13: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 73
	i32 291275502, ; 14: Microsoft.Extensions.Http.dll => 0x115c82ee => 23
	i32 318968648, ; 15: Xamarin.AndroidX.Activity.dll => 0x13031348 => 56
	i32 321597661, ; 16: System.Numerics => 0x132b30dd => 45
	i32 342366114, ; 17: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 76
	i32 377476539, ; 18: Zebble.Slider.dll => 0x167fd5bb => 108
	i32 385762202, ; 19: System.Memory.dll => 0x16fe439a => 44
	i32 442521989, ; 20: Xamarin.Essentials => 0x1a605985 => 95
	i32 450948140, ; 21: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 72
	i32 465846621, ; 22: mscorlib => 0x1bc4415d => 35
	i32 469710990, ; 23: System.dll => 0x1bff388e => 43
	i32 476646585, ; 24: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 73
	i32 476991982, ; 25: MiBu => 0x1c6e51ee => 0
	i32 486930444, ; 26: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 83
	i32 513247710, ; 27: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 33
	i32 526420162, ; 28: System.Transactions.dll => 0x1f6088c2 => 110
	i32 527452488, ; 29: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 101
	i32 539058512, ; 30: Microsoft.Extensions.Logging => 0x20216150 => 28
	i32 545795345, ; 31: Microsoft.Extensions.Logging.Configuration.dll => 0x20882d11 => 25
	i32 548916678, ; 32: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 5
	i32 571435654, ; 33: Microsoft.Extensions.FileProviders.Embedded.dll => 0x220f6a86 => 18
	i32 605376203, ; 34: System.IO.Compression.FileSystem => 0x24154ecb => 114
	i32 627609679, ; 35: Xamarin.AndroidX.CustomView => 0x2568904f => 69
	i32 662205335, ; 36: System.Text.Encodings.Web.dll => 0x27787397 => 50
	i32 663517072, ; 37: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 93
	i32 666292255, ; 38: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 60
	i32 690569205, ; 39: System.Xml.Linq.dll => 0x29293ff5 => 53
	i32 691348768, ; 40: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 103
	i32 692151471, ; 41: Microsoft.Extensions.Logging.Console.dll => 0x294164af => 26
	i32 700284507, ; 42: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 98
	i32 720511267, ; 43: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 102
	i32 731701662, ; 44: Microsoft.Extensions.Options.ConfigurationExtensions => 0x2b9ce19e => 31
	i32 775507847, ; 45: System.IO.Compression => 0x2e394f87 => 113
	i32 789151979, ; 46: Microsoft.Extensions.Options => 0x2f0980eb => 32
	i32 809851609, ; 47: System.Drawing.Common.dll => 0x30455ad9 => 112
	i32 843511501, ; 48: Xamarin.AndroidX.Print => 0x3246f6cd => 85
	i32 928116545, ; 49: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 97
	i32 955402788, ; 50: Newtonsoft.Json => 0x38f24a24 => 36
	i32 956575887, ; 51: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 102
	i32 967690846, ; 52: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 76
	i32 999186168, ; 53: Microsoft.Extensions.FileSystemGlobbing.dll => 0x3b8e5ef8 => 20
	i32 1012816738, ; 54: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 87
	i32 1022671552, ; 55: West.Extensions.XamarinHosting.Abstractions => 0x3cf4bac0 => 54
	i32 1028951442, ; 56: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 15
	i32 1035644815, ; 57: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 59
	i32 1048425084, ; 58: Microsoft.Extensions.Logging.EventSource => 0x3e7db27c => 30
	i32 1052210849, ; 59: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 80
	i32 1083032757, ; 60: Microsoft.Extensions.Logging.EventLog.dll => 0x408dc4b5 => 29
	i32 1084122840, ; 61: Xamarin.Kotlin.StdLib => 0x409e66d8 => 100
	i32 1089913930, ; 62: System.Diagnostics.EventLog.dll => 0x40f6c44a => 42
	i32 1098259244, ; 63: System => 0x41761b2c => 43
	i32 1106973742, ; 64: Microsoft.Extensions.Configuration.FileExtensions.dll => 0x41fb142e => 12
	i32 1110309514, ; 65: Microsoft.Extensions.Hosting.Abstractions => 0x422dfa8a => 21
	i32 1127624469, ; 66: Microsoft.Extensions.Logging.Debug => 0x43362f15 => 27
	i32 1173126369, ; 67: Microsoft.Extensions.FileProviders.Abstractions.dll => 0x45ec7ce1 => 17
	i32 1175144683, ; 68: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 91
	i32 1204270330, ; 69: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 60
	i32 1226878998, ; 70: West.Extensions.XamarinHosting => 0x4920b016 => 55
	i32 1260762174, ; 71: Zebble => 0x4b25b43e => 107
	i32 1264653787, ; 72: West.Extensions.XamarinHosting.dll => 0x4b6115db => 55
	i32 1267360935, ; 73: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 92
	i32 1275534314, ; 74: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 103
	i32 1293217323, ; 75: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 71
	i32 1365406463, ; 76: System.ServiceModel.Internals.dll => 0x516272ff => 117
	i32 1367676925, ; 77: Microsoft.Extensions.Configuration.CommandLine => 0x518517fd => 9
	i32 1376866003, ; 78: Xamarin.AndroidX.SavedState => 0x52114ed3 => 87
	i32 1406073936, ; 79: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 66
	i32 1411638395, ; 80: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 47
	i32 1444513560, ; 81: RangeSeekbar => 0x56198718 => 38
	i32 1462112819, ; 82: System.IO.Compression.dll => 0x57261233 => 113
	i32 1469204771, ; 83: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 58
	i32 1470490898, ; 84: Microsoft.Extensions.Primitives => 0x57a5e912 => 33
	i32 1505131794, ; 85: Microsoft.Extensions.Http => 0x59b67d12 => 23
	i32 1521091094, ; 86: Microsoft.Extensions.FileSystemGlobbing => 0x5aaa0216 => 20
	i32 1541751207, ; 87: RangeSeekbar.dll => 0x5be541a7 => 38
	i32 1582372066, ; 88: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 70
	i32 1592978981, ; 89: System.Runtime.Serialization.dll => 0x5ef2ee25 => 116
	i32 1616559802, ; 90: Zebble.Slider => 0x605abeba => 108
	i32 1622152042, ; 91: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 82
	i32 1632842087, ; 92: Microsoft.Extensions.Configuration.Json => 0x61533167 => 13
	i32 1636350590, ; 93: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 68
	i32 1639515021, ; 94: System.Net.Http.dll => 0x61b9038d => 2
	i32 1657153582, ; 95: System.Runtime => 0x62c6282e => 48
	i32 1658251792, ; 96: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 96
	i32 1698840827, ; 97: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 99
	i32 1729485958, ; 98: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 64
	i32 1766324549, ; 99: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 89
	i32 1767075704, ; 100: Microsoft.Extensions.Configuration.UserSecrets.dll => 0x69536f78 => 14
	i32 1770582343, ; 101: Microsoft.Extensions.Logging.dll => 0x6988f147 => 28
	i32 1776026572, ; 102: System.Core.dll => 0x69dc03cc => 40
	i32 1788241197, ; 103: Xamarin.AndroidX.Fragment => 0x6a96652d => 72
	i32 1796167890, ; 104: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 5
	i32 1808609942, ; 105: Xamarin.AndroidX.Loader => 0x6bcd3296 => 82
	i32 1813058853, ; 106: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 100
	i32 1813201214, ; 107: Xamarin.Google.Android.Material => 0x6c13413e => 96
	i32 1828688058, ; 108: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 24
	i32 1867746548, ; 109: Xamarin.Essentials.dll => 0x6f538cf4 => 95
	i32 1885316902, ; 110: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 61
	i32 1919157823, ; 111: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 84
	i32 1968388702, ; 112: Microsoft.Extensions.Configuration.dll => 0x75533a5e => 10
	i32 1983156543, ; 113: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 99
	i32 2011961780, ; 114: System.Buffers.dll => 0x77ec19b4 => 39
	i32 2019465201, ; 115: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 80
	i32 2026546280, ; 116: AndroidComboSeekbar => 0x78caa468 => 3
	i32 2048278909, ; 117: Microsoft.Extensions.Configuration.Binder.dll => 0x7a16417d => 8
	i32 2055257422, ; 118: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 77
	i32 2072397586, ; 119: Microsoft.Extensions.FileProviders.Physical => 0x7b864712 => 19
	i32 2079903147, ; 120: System.Runtime.dll => 0x7bf8cdab => 48
	i32 2090596640, ; 121: System.Numerics.Vectors => 0x7c9bf920 => 46
	i32 2097448633, ; 122: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 74
	i32 2181898931, ; 123: Microsoft.Extensions.Options.dll => 0x820d22b3 => 32
	i32 2192057212, ; 124: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 24
	i32 2193681939, ; 125: Microsoft.Extensions.Configuration.EnvironmentVariables.dll => 0x82c0ee13 => 11
	i32 2201107256, ; 126: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 104
	i32 2201231467, ; 127: System.Net.Http => 0x8334206b => 2
	i32 2217644978, ; 128: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 91
	i32 2244775296, ; 129: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 83
	i32 2256548716, ; 130: Xamarin.AndroidX.MultiDex => 0x8680336c => 84
	i32 2266799131, ; 131: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 7
	i32 2279755925, ; 132: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 86
	i32 2315684594, ; 133: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 57
	i32 2371007202, ; 134: Microsoft.Extensions.Configuration => 0x8d52b2e2 => 10
	i32 2383496789, ; 135: System.Security.Principal.Windows.dll => 0x8e114655 => 49
	i32 2471841756, ; 136: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 137: Java.Interop.dll => 0x93918882 => 4
	i32 2501346920, ; 138: System.Data.DataSetExtensions => 0x95178668 => 111
	i32 2505896520, ; 139: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 79
	i32 2506663852, ; 140: Xamarin.RangeSlider.Droid => 0x9568a7ac => 106
	i32 2509217888, ; 141: System.Diagnostics.EventLog => 0x958fa060 => 42
	i32 2562349572, ; 142: Microsoft.CSharp => 0x98ba5a04 => 6
	i32 2563961879, ; 143: West.Extensions.XamarinHosting.Abstractions.dll => 0x98d2f417 => 54
	i32 2570120770, ; 144: System.Text.Encodings.Web => 0x9930ee42 => 50
	i32 2581819634, ; 145: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 92
	i32 2587639474, ; 146: Xamarin.RangeSlider.Common.dll => 0x9a3c3eb2 => 105
	i32 2588805703, ; 147: Microsoft.Extensions.Logging.EventSource.dll => 0x9a4e0a47 => 30
	i32 2592341985, ; 148: Microsoft.Extensions.FileProviders.Abstractions => 0x9a83ffe1 => 17
	i32 2592924844, ; 149: Olive.dll => 0x9a8ce4ac => 37
	i32 2605712449, ; 150: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 104
	i32 2616218305, ; 151: Microsoft.Extensions.Logging.Debug.dll => 0x9bf052c1 => 27
	i32 2620871830, ; 152: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 68
	i32 2633051222, ; 153: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 78
	i32 2732626843, ; 154: Xamarin.AndroidX.Activity => 0xa2e0939b => 56
	i32 2737747696, ; 155: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 58
	i32 2770495804, ; 156: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 98
	i32 2778768386, ; 157: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 94
	i32 2810250172, ; 158: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 66
	i32 2819470561, ; 159: System.Xml.dll => 0xa80db4e1 => 52
	i32 2853208004, ; 160: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 94
	i32 2855708567, ; 161: Xamarin.AndroidX.Transition => 0xaa36a797 => 90
	i32 2903344695, ; 162: System.ComponentModel.Composition => 0xad0d8637 => 115
	i32 2905242038, ; 163: mscorlib.dll => 0xad2a79b6 => 35
	i32 2911054922, ; 164: Microsoft.Extensions.FileProviders.Physical.dll => 0xad832c4a => 19
	i32 2919462931, ; 165: System.Numerics.Vectors.dll => 0xae037813 => 46
	i32 2968338931, ; 166: System.Security.Principal.Windows => 0xb0ed41f3 => 49
	i32 2971004615, ; 167: Microsoft.Extensions.Options.ConfigurationExtensions.dll => 0xb115eec7 => 31
	i32 2978675010, ; 168: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 71
	i32 3024354802, ; 169: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 75
	i32 3078985232, ; 170: Zebble.dll => 0xb7859610 => 107
	i32 3109243939, ; 171: Microsoft.Extensions.Logging.Configuration => 0xb9534c23 => 25
	i32 3111772706, ; 172: System.Runtime.Serialization => 0xb979e222 => 116
	i32 3124832203, ; 173: System.Threading.Tasks.Extensions => 0xba4127cb => 120
	i32 3188578740, ; 174: Microsoft.Extensions.Configuration.EnvironmentVariables => 0xbe0dd9b4 => 11
	i32 3204380047, ; 175: System.Data.dll => 0xbefef58f => 109
	i32 3211777861, ; 176: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 70
	i32 3236886769, ; 177: Microsoft.Extensions.Logging.EventLog => 0xc0eef8f1 => 29
	i32 3247949154, ; 178: Mono.Security => 0xc197c562 => 119
	i32 3258312781, ; 179: Xamarin.AndroidX.CardView => 0xc235e84d => 64
	i32 3265893370, ; 180: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 120
	i32 3267021929, ; 181: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 62
	i32 3289471842, ; 182: Olive => 0xc4115b62 => 37
	i32 3317135071, ; 183: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 69
	i32 3317144872, ; 184: System.Data => 0xc5b79d28 => 109
	i32 3340431453, ; 185: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 61
	i32 3353484488, ; 186: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 74
	i32 3358260929, ; 187: System.Text.Json => 0xc82afec1 => 51
	i32 3362522851, ; 188: Xamarin.AndroidX.Core => 0xc86c06e3 => 67
	i32 3366347497, ; 189: Java.Interop => 0xc8a662e9 => 4
	i32 3374999561, ; 190: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 86
	i32 3395150330, ; 191: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 47
	i32 3404864099, ; 192: Microsoft.Extensions.Hosting.dll => 0xcaf21a63 => 22
	i32 3404865022, ; 193: System.ServiceModel.Internals => 0xcaf21dfe => 117
	i32 3421170118, ; 194: Microsoft.Extensions.Configuration.Binder => 0xcbeae9c6 => 8
	i32 3428513518, ; 195: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 16
	i32 3429136800, ; 196: System.Xml => 0xcc6479a0 => 52
	i32 3430777524, ; 197: netstandard => 0xcc7d82b4 => 1
	i32 3434026225, ; 198: AndroidComboSeekbar.dll => 0xccaf14f1 => 3
	i32 3471231830, ; 199: Microsoft.Extensions.Hosting => 0xcee6cb56 => 22
	i32 3476120550, ; 200: Mono.Android => 0xcf3163e6 => 34
	i32 3485117614, ; 201: System.Text.Json.dll => 0xcfbaacae => 51
	i32 3486566296, ; 202: System.Transactions => 0xcfd0c798 => 110
	i32 3501239056, ; 203: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 62
	i32 3509114376, ; 204: System.Xml.Linq => 0xd128d608 => 53
	i32 3567349600, ; 205: System.ComponentModel.Composition.dll => 0xd4a16f60 => 115
	i32 3620450613, ; 206: Microsoft.Extensions.Configuration.CommandLine.dll => 0xd7cbb135 => 9
	i32 3627220390, ; 207: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 85
	i32 3641597786, ; 208: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 77
	i32 3657292374, ; 209: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 7
	i32 3672681054, ; 210: Mono.Android.dll => 0xdae8aa5e => 34
	i32 3676310014, ; 211: System.Web.Services.dll => 0xdb2009fe => 118
	i32 3682565725, ; 212: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 63
	i32 3689375977, ; 213: System.Drawing.Common => 0xdbe768e9 => 112
	i32 3718780102, ; 214: Xamarin.AndroidX.Annotation => 0xdda814c6 => 57
	i32 3722202641, ; 215: Microsoft.Extensions.Configuration.Json.dll => 0xdddc4e11 => 13
	i32 3748608112, ; 216: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 41
	i32 3758424670, ; 217: Microsoft.Extensions.Configuration.FileExtensions => 0xe005025e => 12
	i32 3786282454, ; 218: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 65
	i32 3829621856, ; 219: System.Numerics.dll => 0xe4436460 => 45
	i32 3841636137, ; 220: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 15
	i32 3885922214, ; 221: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 90
	i32 3896760992, ; 222: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 67
	i32 3920810846, ; 223: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 114
	i32 3921031405, ; 224: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 93
	i32 3945713374, ; 225: System.Data.DataSetExtensions.dll => 0xeb2ecede => 111
	i32 3955647286, ; 226: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 59
	i32 3963903781, ; 227: Microsoft.Extensions.Configuration.UserSecrets => 0xec445f25 => 14
	i32 4021363427, ; 228: Xamarin.RangeSlider.Droid.dll => 0xefb122e3 => 106
	i32 4025784931, ; 229: System.Memory => 0xeff49a63 => 44
	i32 4075152723, ; 230: Microsoft.Extensions.Logging.Console => 0xf2e5e553 => 26
	i32 4078967171, ; 231: Microsoft.Extensions.Hosting.Abstractions.dll => 0xf3201983 => 21
	i32 4101050201, ; 232: MiBu.dll => 0xf4710f59 => 0
	i32 4105002889, ; 233: Mono.Security.dll => 0xf4ad5f89 => 119
	i32 4126470640, ; 234: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 16
	i32 4151237749, ; 235: System.Core => 0xf76edc75 => 40
	i32 4182413190, ; 236: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 81
	i32 4213026141, ; 237: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 41
	i32 4260525087, ; 238: System.Buffers => 0xfdf2741f => 39
	i32 4265354583, ; 239: Xamarin.RangeSlider.Common => 0xfe3c2557 => 105
	i32 4292120959, ; 240: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 81
	i32 4294648842 ; 241: Microsoft.Extensions.FileProviders.Embedded => 0xfffb240a => 18
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [242 x i32] [
	i32 79, i32 97, i32 36, i32 88, i32 88, i32 101, i32 65, i32 89, ; 0..7
	i32 63, i32 75, i32 6, i32 118, i32 78, i32 73, i32 23, i32 56, ; 8..15
	i32 45, i32 76, i32 108, i32 44, i32 95, i32 72, i32 35, i32 43, ; 16..23
	i32 73, i32 0, i32 83, i32 33, i32 110, i32 101, i32 28, i32 25, ; 24..31
	i32 5, i32 18, i32 114, i32 69, i32 50, i32 93, i32 60, i32 53, ; 32..39
	i32 103, i32 26, i32 98, i32 102, i32 31, i32 113, i32 32, i32 112, ; 40..47
	i32 85, i32 97, i32 36, i32 102, i32 76, i32 20, i32 87, i32 54, ; 48..55
	i32 15, i32 59, i32 30, i32 80, i32 29, i32 100, i32 42, i32 43, ; 56..63
	i32 12, i32 21, i32 27, i32 17, i32 91, i32 60, i32 55, i32 107, ; 64..71
	i32 55, i32 92, i32 103, i32 71, i32 117, i32 9, i32 87, i32 66, ; 72..79
	i32 47, i32 38, i32 113, i32 58, i32 33, i32 23, i32 20, i32 38, ; 80..87
	i32 70, i32 116, i32 108, i32 82, i32 13, i32 68, i32 2, i32 48, ; 88..95
	i32 96, i32 99, i32 64, i32 89, i32 14, i32 28, i32 40, i32 72, ; 96..103
	i32 5, i32 82, i32 100, i32 96, i32 24, i32 95, i32 61, i32 84, ; 104..111
	i32 10, i32 99, i32 39, i32 80, i32 3, i32 8, i32 77, i32 19, ; 112..119
	i32 48, i32 46, i32 74, i32 32, i32 24, i32 11, i32 104, i32 2, ; 120..127
	i32 91, i32 83, i32 84, i32 7, i32 86, i32 57, i32 10, i32 49, ; 128..135
	i32 1, i32 4, i32 111, i32 79, i32 106, i32 42, i32 6, i32 54, ; 136..143
	i32 50, i32 92, i32 105, i32 30, i32 17, i32 37, i32 104, i32 27, ; 144..151
	i32 68, i32 78, i32 56, i32 58, i32 98, i32 94, i32 66, i32 52, ; 152..159
	i32 94, i32 90, i32 115, i32 35, i32 19, i32 46, i32 49, i32 31, ; 160..167
	i32 71, i32 75, i32 107, i32 25, i32 116, i32 120, i32 11, i32 109, ; 168..175
	i32 70, i32 29, i32 119, i32 64, i32 120, i32 62, i32 37, i32 69, ; 176..183
	i32 109, i32 61, i32 74, i32 51, i32 67, i32 4, i32 86, i32 47, ; 184..191
	i32 22, i32 117, i32 8, i32 16, i32 52, i32 1, i32 3, i32 22, ; 192..199
	i32 34, i32 51, i32 110, i32 62, i32 53, i32 115, i32 9, i32 85, ; 200..207
	i32 77, i32 7, i32 34, i32 118, i32 63, i32 112, i32 57, i32 13, ; 208..215
	i32 41, i32 12, i32 65, i32 45, i32 15, i32 90, i32 67, i32 114, ; 216..223
	i32 93, i32 111, i32 59, i32 14, i32 106, i32 44, i32 26, i32 21, ; 224..231
	i32 0, i32 119, i32 16, i32 40, i32 81, i32 41, i32 39, i32 105, ; 232..239
	i32 81, i32 18 ; 240..241
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
