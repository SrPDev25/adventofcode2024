﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class Part2
    {

        public static void Run()
        {
            string puzzle = "KKUUIIIIIIIIIIIIMMMMMMMMMVVVVVVVVVVVVVVVVNNNNNTTTTTTTTTTMMBMYYKKKKRPPPPXXXXXXXXXXXXXXFFFFFFFFFFFNNNNNNNNNNNNNNNNNNNTTTTTTTTJJJFFFFFFIFMJEEEE\r\nKKUUIIIIIIIIIIIIIMMMMMMMMMVVVVVVVVVVVVVVFAEEENNTTTTTTTTNMMMMYYKKKKKPPPPPPXXXXBBBXXXXXPFFFFFFFFFFNNNNNNNNTTTNNTTNNNTTTTTTTTTJJJFJFFFFFFJJJJEE\r\nKKUUIIIIIIIIIIIIIIMMMMMMMMMVVVVVVVVVVTZVFEEENNTTTTTTTTTMMMMLKKKKKKKPPPPPXXXXBBBBXXXXXXFFFAFFFFFFFFNWWNTTTTTTTTTTTTTTTTTTTTJJJJJJFFFFFFFJJJJE\r\nKKUUUUIIIIIIIIIIIIHEMMMMMMVVVVVVVVEEEEEEFFEEENTTUTTTTTMMMMMMKKKKKKKPPPPPPPPPBZBBXXBXXXXFFFFFFFFFFFFCWWTTTTTTTTTTTOOOTOTOOTJJJJJJJAAFFJJJJJJJ\r\nKKUUUUUUIIEEIIIIIHHHMMHMMMVVVVVVVVEEEEEEFFEENNTTTTTTTTMMMMMMMKKKKKPPPPPPPPPBBBBBBBBXXFFFFFFFFFFFFFFFWWWWTTTTTTTTTOOOOOOOOTJJJJAJJAFFFJJJJJJJ\r\nKKKUUUUUUIEEEIEIIIHHHHHHMMVVVVVVVVEEEEEEFFFFNNNTTTTTTMMMMMXXMKKKKKKKPPPPPPPVBBBBBBBXXFFFFFFFFFFFFFFWWWWTTTTTTTTOOOOOOOOOOOAJAAAAAAFFJJJJJJJJ\r\nKUUUUUUUIIEEEEEIIHHHHHHHVVVVCVHHHVEEEEEEFFFFFNNTTTTTTTMMMMMXXKKKKKPPPPPPPPPVVBBVBBBBBBFFFFFFFFFFFFFFCWWTTTTTTTTOOOOOOOOOOOAAAAALLAAAAJJJJJJJ\r\nKUUUUUUUIEEEEEEEEEEHHHHCVVCCCVGGGGEEEEEEFFFFFFNNNTTTTTTFMKKMKKKKKPPPPPPCVFPVVVVVVVVBBFFFFFFFFFFFFFFFFFWTWATTTTTOOOOOOOOOOOAAAAAAAAAAJJJJJJJJ\r\nKUUUUUIIIEEEEEEEEEEHHHHCCCCCCGGGGGEEEEEEFBFFFFNNGTTTTTTFFMKMEKJJJJBPPPPVVFVVVVVVVXVBBBBFFFFFFFFFFFFFFWWWWTTTOOOOOOOOAOAAAOAAAAAAAAAAAJJJJJJJ\r\nKKUUUUUUIEEEEEEEEEHHHHHHHHCCCGGGGGEEEEEEEEEEFFGGGTTTTTMMMMMMEKEJJBBPPPPBVVVVVVVVVVVBBBBFIFFFFFFFFFFWWWWWWWOTTGNOOOOAAAAAAAAAAAAAAAAAJJJJJJJJ\r\nKKUUUUIIIEEEEEEEEEEHHHHHHHCCOOYGGGEEEEEEEEEEGGGGGMMMMMMMMMMMEEEJJJBBPPVVVVVVVVVVVVBBBBBBFFFFFFFFFWWWWWWWWNNNNNNNNOOAACAAAAAAAAAAAAAAAJJJJJJJ\r\nKKKUUUIVIIVEEEEEEEHHHHHHHOHCOOYGGGEEEEEEEEEEGGGGGMMEMMMMMMKMEEJJJFJJJUUVVVVVVVVVVVVVBBKBKFFFWFFFWWWWWWNNNNYNNNNNYNNDDDDDAAAAAAAAAAAAJJJJJJJE\r\nKKUUUUIVIVVEEEVEHHHHHHHHHHHCOOYOOYEEEEEEEEEEGGGMMMMMMMMMMMMVKEEJJJJJJUUVVVVVVVVVVVVBBBKKKKFFWFWWWWWWWWWGNNNNNNNNNNNNDDDDDAAAAAAAAAAAJKJJJJJE\r\nKKUUUUIVVVVVVVVEEHHHHHHHHHCCCOOOOYEEEEEEEEWGGGGGAMMMMMMMMMMVKKKJJJJJJJUUVVVVVVVVVFFBKKKKKKKFWWWWWWWWWWNNNNNNNNNNDDDDDDDDDDAAAAAAAAKAKKJJJJEE\r\nKKUUUUIVVVVVVVVEEEHHHHHHCCCOOOOOOOEEEEEEEEGGGGGGGMMMMMMMMMMKKKJJJJJJJJJUVVVVVVVVVVFFFKKKKKKWWJWWWWWWWWNNNXXXXNNNDDDDDDDDDDDAAAAKKKKKKKKKJJJE\r\nKKLUIIIIVVVVVVVEEHHHHHHHCCKKKOOOOOEEEEEEEEGGGGGGGMMMIMMMMMMKKKKKJJJJJJRVVVVVVJVVUFFFFKKKKJJWWJWWWWWWWWNNNXXXXNNNNNNDDDDDDDDDKKKKKKKKKKKKKKKE\r\nLLLLLIIVVVVVVVVVVHHHHHHCCCCKXOOOOOOORRKRRRGGGGGGGGMMIMMMMMMKKKKJJJJJJJRVAVJJVJJUUFFUKKKKJJJJWJJWWWWWWWNENXXXXNNNNNDDDDDDDDDDDKKKKKKKKKKFFKKK\r\nLLLLLLLVVVVVVVVVVSHHHCCCCCKKOOOOOOORRRRRRGGGGGGGGGGGGKMMMKKKKKKKKKJJJJJJJJJJJJJUUFUUUKKKKJJJJJJJWWWWWXXXXXXXXNNNNNDDDDDDDDDDDDKZKKZKKKKFFKKP\r\nLLLLLXXVXVVVVVVVVVHHCCCCCCKKOOOOOOORRRRRRGGGGGGGKKGGKKKMKKKKKKKKJJJJJJJJJJJJJUUUUUUUUUCJFJJJJJWWWWWWWXXXXXXXXNNNNNDDDDDDDDDDDKKZZZZKFFFFFFFF\r\nLLLLLLXXXVVVVVVVVVTMMMMCCCKOOOOOOORRRRRRRGGGGGGGGKKKKKKKKKKKKKKKKJJJJJJJJJJJUUUUUUUUUJCJJJJJJJJJJWWWWXXXXXXXXNNNNNNDDDDDDDDDDKKZZZZKKKKFFFFF\r\nLLLLLALXXVVVVVVVVVMMMMMMCCCOOOOORRRRRRRRXGGGGGGGKKBBBBBBBBKKKKKKKKJJJJJJJJJJUUUUUUUUJJJJJJJJJJJJJWWWWXXXXXXXXNNNNNNDDDDDDDZZZZZZZZZKKKKFFKKI\r\nLLLLLLLXXVVVVVVVVVMMMMMMOOOOOOOOORRRRRRRRRGGGGGGKKBBBBBBBBBBBBBKKXJJJJJJJJJJUUUUUUUJJJJJJJJJJJJJJJWWWXXXXXXXXNNNNNNDDDDDZZZZZZZZZZZKKKKKKKII\r\nLLLLLCLLCVVSVVSSVMMMMMMPOOOOOOOOORRRRRRRVVGGGGUUUUBBBBBBBBBBBBBDXXJJJJJQQQQQQUUUUUUJJJJJJJJJJJJJUUUWWXXXXXXNNNNTNNNDDDDDDZZZZZZZIIIUUUUKKIII\r\nLLLWLLLHCSSSVVSMVMMMMMMMMLLOOOOOOORRRRRRVVGGPPUBBBBBBBBBBBBBBBBXXXXJJJJJQQQQQUUUUUUUJJJJJJJJJJJJJJJWWXXXXXXTTTTTTTDDDDDDDZZZZZZZIIIIUUIKKKKI\r\nLLLWCMCCCSSSSSSMMMMMMMMMMLLOOVOORRRRRRRVVVGGPUUBBBBBBBBBBBBBBBBXXXXJJJJJQQQQQUUUUUUUUUJJJJJJJJJJJJJJTXXXXXXTTTTTTTDDDDDDDZZZZZZZZIIIUUIIIIII\r\nLLLCCCCCCSSSSSMMMMMMMMMMLLOOVVOOORRRRRRVVUJUUUUBBBBBBBBBBBBBBBBXXXXXJJJQQQQUUUUUUUUUUUJJJJJJJJJJJJJJTXXXXXXTTTTTTTJDDDDDZZZZZIIIIIIIUIIIIIII\r\nCCYCCCCCCCCSSSSMMMMMMMMTOOOVNVVOVRERRRRRVUUUPUUBBBBBBBBBBBBBBBBXXXDDJEEEQQQMMMUUUUUUUUUZJJJJJJJJJJJTTXXXXXXTTTTTTTJJDTDDZVZZZIIISIIIIIIIIIII\r\nCCCCCCCCCSSMMMMMMMMMMMMOOGVVVVVOVVERRRRRUUUUUUUUUMBBBBBBBBBBBBBXXXXXEEEQQQMMEMUUUUUUUZZZZZJJJJJJJTTTTTOTOOOOOTTTTJJJJNDVVVVZZISSSSSSSSSIIIII\r\nCCCCCCCCSSSSMMMMMMMMMMPPIIVVVVVOVVRRRRRUUUUUUUMMMMMBBBBBBBBXXXXXXXXXEEUUXXEEEMUUUUUUUZZZZZJJJJJJJTTTTOOOOOOOGTOOJJJOJNVVVVZZZSSSSSSSSSIIIIII\r\nCCCCCCCCCCCSSSMMMMMMMMPPPIIVVVVVVVVRRRRUUUUUUUUUMMMBBBBBBBBXXXXXXXXEEUUHEEEEMMUUUUUUUUZZZGGGGJJTTTTTTOOOOOOOOOOOOOOONNVNVVVVVSSSSSSSSIIIIIII\r\nCCCCCCCCCCCSSSMMMMMMMMPPIIIIVVVVVVVRPPPUUUUUUUUUZMMBBBBBBMMXMXXXXXXXUUUUEEEEMMMUUUUMMMMZTTGTTTTTTTTTOOOOOOOOOOOOOOONNNNNNVVVVVSSJSSSIIIIIIII\r\nCCCCCCCCCCCCSSMLLIIMIIIPIIIIVVVVPPPPPPPUUUUUUUZZZZZZZZBBBMMMMXXXXXDDDDUUSEEEEMMMMMMMMMMTTTTTTTTTTTTTTOOOOOOOOOOOOOONNNNNNVVVVVSJJSSIIIIIHIHH\r\nECCCCCCCCCCCSSSIIIIIIIIIIIIIIVVVVVVVPPPURUUUUUUZZZZZZZMMMMMMXXXXXXXDDDDEEEMMMMMMMMMMMMMMMMTTTTTTTVVVTTMMOOOOOOOOOOONNNNNNNNVVVHHJSHIIIIHHHNH\r\nEECCCCCCCCCCCSSSIPIIIIIIIIIIIIIIUUUVVPPPPUUUUUZZZZZZZMMMMMMMMMXXXDDDDDKKEEMMMMMMMLMMMMMMMTTTTTVVTVVVVTTTOOLOOOOOOOONNNNNNNNVVVHHHHHIIHIHHHHH\r\nEEEECCUUCCCCSSSIIIIIIIIIIIIIIIIIUUUVUUPPPUUUUUZZZZZZZZMMMMMMMMXXXJDDDDEEJEMMMMLLLLLLMMMMMMTTVVVVVVKKKKKLLLLOOOOOOOONNNNNNNNNNVVHHHHHHHHHHHHH\r\nEEEECCCUUCCCSSSIIIIIISIIIIIIIIIIMUUUUUUUUUUUUUUMZZZZBBBMMMMMMMXXJJJFDDEEEEEEMMLLLLLLLMMMMMMMVVVVHVKNKKKKOLOOOOOOOOONNNNNNNNNNHHHHHHHHHHHHHHH\r\nEEUUUUUUUUUCSIIIIIIIIIICIIIIIIIIMMUUUUUUUUUUUUUMZZMMBBBMMMMMMMXXXJJJAAEEEEEEEEFLLLLLLMMMMMVVVVVVVVKKKKKKOOOOOOOOOONNNNNNNNNNGHHHHHHHHHHHHHHH\r\nEEUUUUUUUUUUUIIIIIIIIIIIIIIIIIIIMMUUUUUUUUUGUUGMMZMMBBBMMMMMMJJJJJAAAAEEEEEEEEELLLLLLMMMKMMVVVVVVVKKKKKOOOOOOOOOOONNNNNNNNNNNTTTTTHHHHHHHHHH\r\nEEUUUUUUUUUUUIIIIIIIIIIIIIIIIIIMMMMMMUUUUUUGGGGGMMMMMBMMMMMMMJJJJJJJEEEEEEEEEEELLLLLLMKMKKKVVVKVKKKKKKKOKKOOOOOOOOOOONNNNNNTTTTTTHHHHHHHHHHH\r\nEEUUUUUUUUUUULLIIIIIIIIIIIIIIIMMMMTMMMUUGGUGGGGGMMMMMMMMMMMJJJJJJJJJEEEEEEELELLLLLLLLKKKKKKDDKKKKKKKKKKKKKKKOOOGOOFNNNNNNNNTTTTTHHHHHHHHHHHH\r\nEUUUUUUUUUUUULIUIIIIIIIYIIIIIIIMMTTSSCCCGGGGGGGGGGMMMMMMMHHJJJJJJJJJJJEEEEELLLLLLLLLLKKKKKKDDDKKKKKKKKKKKKKKKOOOOONNDDDDDNNJTJTTHHHHHHHHHHHH\r\nEEUUUUUUUUUUUUIIIIJIIIIYYYIDIIIMTTTSSSSGGGGGGGGGGGMMMMMHHHHJJJJJJJJJJEEEEEEELLLLLLLLLKKKKKKKSSSSSSKKKKKKKKKKKKKKKODDDDDJJJJJTJJHHHHUHHHHHHHH\r\nEHHHUUUUUUUUUUIIIJJJIIIIYYYYYTTTTTTTSSSSGGGGGGGGGGGGGHHHHHHHJJJJJJJJEEEEEEEELLLLLLLLLLKKKQQQSSSSSSKKKKKKKNKKKKNKKDDDDDDJJJJJTJJHHHUUHHHHHHHH\r\nHHHHHUUUYUUUUUYYYYJJJIYYYYYYYTTTTTTSSSSSYGGGGGGGGGGHHHHHHHHHJJJJJJJJEEEEEEEELLLLLLLLLLLKKKQQSSSSSSKKKKKKNNNNKKNNDDDDDJJJJJJJJJJJUUUUUUHHHHHH\r\nHHHHHUYUYUUUYYYYYYYYYIYYYYYYIIITTTUSSSSSSGGGGGGGGGZHHHHHHHHHJJJJJJJEEEEEPEEELLLLLLLLLLKKKQQQSSSSSSSSSSSKNNNNNNNNDJJJJJJJJJJJJJJJUUUUUUUHUHHH\r\nHHHHHUYYYYYYYYYYYYYYYYYYYYYIIIATBZZZSSSSSSSSSGGGGGZHHHHHHHHHHHHJGJJEEEEEEERLLLLSSLLLLLKKKQQQSSSSSSSSSSSKNNNNNNNNDJJJJJJJJJJJJJJJUUUUUUUUUUHH\r\nHHHHHYYYYYYYYYYYDDDDYDYYYYYIIIIGZZZSSSSSSSSGGGGGGGZHHHHHHHHHHHHJJJJEEEEEEEELISSSSLLLLLKQQQQQQQSSSSSSSSSHNNNNNNNDDNNJJJJJJJJJYJYJUUUUUUUUUUUH\r\nHHHHHHHYYYYYYYYYDDDDDDYYIIYIIGGGZZZZZSSSSSSSGZGGGZZHHHHHHHHHHHHJHHHHHEEEEEEIISSSSLLLLKKQQQQQQQSSSSSSSSSNNNNNNNNNNNNNJJJJJJJJYYYYUUUUUUUUUUUH\r\nHHHHHHHHHHYYYYYYDDDDDBIIIIIIIIIIZZZZZSSSOONSSZZZZZHHHHHHHHHHHIHHHHJJJJJEYYYSSSSSSLLLLVQQQQQQQQSSSSSSSSSANNNNNNNNNNRRJJJJJJYJYYYYUUUUUUUUUUUT\r\nHHHHHHHHHHYYYYDDDDDDDIIIIIIIIIZZZZZZSSZOOONSZZZZZZHZZZHHHHHHHIHHHHJJJJJEYSSSSSSSSSLLSQQQQQQQQCSSSSSSSSSNNNNNNNNNQNRRRRJJJYYYYYYYUUUUUUUUUUUU\r\nHHHHHHHHHYYYYYYDDDDDDDIIIIIIIIZZZZZZZZOOOOOZZZZZZZZZZZHHHHHHHIHHIIJJJJJESSSSSSSSSSSSSSQQQQQQWWSSSSSSSSSNNNNNNNNZNNRRRRRYYYYYYYYYYUUUUUUUQQQQ\r\nHHHHHHHHHYYDDDDDDDDDDDDDIIIIIIIZZZZZZZOOOZZZZZZQQZZZZZHHHHHHHIIIIEJJJJJSSSSSSSSSSSSSWWWQQQQWWWSSSSSSSSSVNNNNNNTTTRRRRRYYYYYYYYYYYYWUUUUUQQQQ\r\nHHHHHHHHHYYDDDDDDDDDDDDDIIIDIDDZZZZZZOOZZZZZZZZZQZZQZHHHHHHHHIEEEEEJJJJSJSSSSSSSSSSSSSWWWWWWWWSSSSSSSSSVNNNXXXTTTRRRRRYIYYYYYYYYYYUUUUUUUQQQ\r\nHHHHHHBHHYYDYDDDDDDDDDDDDDIDDDDDWWZZZOZZZZZZZZZQQQQQZAHHHHHHHIIEEEEEJJJJJSSSSSSSSSRSSSWWWWWWWWWSSSSSSVVVNNNNXTTTRRRRRYYYYCYYYYYYYYYIQQQUQQQQ\r\nOHHHHHHHHYYYYDZDDDDDDDDDDDDDDDDDDWWZZZZZZZZZZZQQQQGGGHHMMEHEHEEEEEJJJJJJJSSSSSSSSSRRRSWWWWWWWWWSSSSSSSSSNNPTTTTTTRRRYYYYYYYYYYYYYYYIQQQQQQQQ\r\nHHHHHHHHYYYYYYZDDLLDDDDDDDDDQQQDWWZZZZZZZZZZZQQQQQQGGQEEEEEEHEEEEEEEJEJDDSSSSSSSSSRRRWWWWWWWWWWSSSSSSSSSNPPTTTTTTTTTZYYYZYYYYYYYYYIIIQQQQQQQ\r\nHHHHHHYYYYYYYYZDMMLDDDDDDDDDQQQQWWWZZFZZFZZZZQQQQQQQQQQEEEEEEEEEEEEEEEJDSSSSSSSSSRRRRWWWWWWWWWWWWSSSSSSSPPPEEEEEEEEEZZZZZYYYYYYYYYYIIIIIQQQQ\r\nHHHOHHYYYYYYYYZZLMLLDDDDDDDDQQQQWWWWZFFFFFFZZQQQQQQQQQEEEEEEEEEEEEEEEEDDSSSSSSSSSRRRRRWNNNNNWWWWWWWOOVOOOPTEEEEEEEEEZZPPZYYYYYYYIIIIIIIIQQQQ\r\nHHHOOOYYYYYYYYZLLLLLDDDDDDQQQQQQQWWCFFFFFFFZZQQQQQQQQQQQQEEEEEEEEEEEEEDDDDSSSSSSRRRRRXNNNNNNWWWWWRROOOYOOOTEEEEEEEEETZZPYYYYYYYYYIIIIIIIQQQQ\r\nOOOOOOYYYYYYYMSLLLLLDDLDQQQQQQQQQQQCFFFFFFFZZQQQQQQQQQQSSEEEEEEEEEEEEEDDDDDDDSFSSSRRXXNNNNNNNNWWWWOOOOOOOOVEEEEEEEEETZPPYYYYYYKYYYMIIIIIOOOO\r\nOOOOOYYYYYYYYMSLLLLLLLLLQQQUUQQQQQFFFFFFFFFFFQQQQQQQQQQQSEEEEEEEEEEEEEDDDDDDDFFSZERRXXNNNNNNNWWWWWOOOOOOOOOEEEEEEEEEVPPPYYKKKKKYYYIIIIIUOOOO\r\nOOOOOYYYYYSSSSSSLLLLLLLLHQQQUQQQQQQQFFFFFFFFFQQQQQQQQQQQSEEEEEEEEEEEEEDDDDDDDDDDEERRXNNNNNNNNNWWWHOOOOOOOOOEEEEEEEEEPPPPPYKKKKKYYYKKIIIIOOOO\r\nOOOOOOYYYSSSSSLPLLLLLLLLQQQQQQQQQQQQFFFFFFFFFQQQQQQQQQQQQEEEEEEEEEEDEDDDDDDDDDDDEEEEEENNNNNNNNWHHHHOOOOOOOOOEEEEETPPPPPPPPPKKKKKYYKKKKOOOOOO\r\nOOOOOOSYYSSSSSLLLLLLLLLLQQQQQQQQQQQQFFFFFFFQQQQQQQQQQQQQEEEEEEEEEEEDDDDDDDDDEEEEEEEEENNNNNNNNNHHOOOOOOOOOOOOEEETTOOPPPPPPPPPPPPPYKKKKKOOOOOO\r\nOOOOOSSSSSSSSSLLLLNNNNNNNNNNNNNQQQQQFFFFFFFFQQQQQQQQQQQMMEEEEEEUUEEDDDDDEEEDDDEEEEEEEEEPNNNNNNHHOOOOOOOOOOOOEEETTOOPPPPPPPPPPPIDDDKKKOOOOOOO\r\nOOOOOOSSSSSSSSSLLLNNNNNNNNNNNNNQQQQQQQQFFFFFFEMQQQQQQQQQMMEEEERMMMDDDDDEEEEEDEEEEEEEEEEPNNNNNNNHOOOOOOOOOOOOEEEOOOPPPPPPPPPPPPPPDDKKOOOOOOOO\r\nYOOOOOSSSSLLLLLLLLNNNNNNNNNNNNNQQQQQQQQFFFZMMMMMMQQQMQMMMMMVERRFFMMDDDDDDEEEEEEEEEEPPPPPPPPNNWWWOOOWWOWFFFFFFFFFFOPPPPPPPPPPPPPDDDOOOOOOOOOO\r\nYOYOOOSSSSLLLLLLGLNNNNNNNNNNNNNNQQQQQFFFFOMMMMMMMQMMMMMMMMVVFFFFYFMMDTEEEEEEEEEEEPPPPPPPPPPWNWWWWOWWWWWFFFFFFFFFFOPPPPPPPPPPPPPDDPOOOOOOOOOO\r\nYYYYOOSSSSSLXXLLGGNNNNNNNNNNNNNNQQQQFFFFFFMMMMMMMMMMMMMMMMMMFFFFFFMTTTEEEEEEEEEEEEPPPPPPPPWWWWWWWWWWWWWFFFFFFFFFFOPPPPPPPPPPPQQDPPOOOOOOOOOO\r\nYYYYOOOSSSSSSXXGGGNNNNNNNNNNNNNNNNNNNFFFFMMMMMMMMMMMMMMMMMMFFFFFFFXTTTEEEEEEEEEEEEPPPPPPPPPWWWWWWWWWWWWFFFFFFFFFFOOPPPPPPPPPPPPPPOOOOOOOOOOO\r\nYYYYYOYXSXXXSXGGGPNNNNNNNNNNNNNNNNNNNFFFMMMMMMMMMMMMMMEZMMMFFFFFXXXEEEEEEEEEEEEEEEPPPPPPPWWWWWWWWWWWWWWFFFFFFFFFFJOOPPPPPPPPOOPPPPOOOOOOOOOO\r\nYYYYYYYXXXXXXXXGPPNNNNNNNNNNNNNNNNNNNNFFMMMMMMMMMMMMMEEMMFFFFFFFFXXXEEEEEEEEEEEEEPTPPPPPPWWWWWWWWWWWWWWFFFFFFFFFFJOPPPPPPPPPOOOPPPOOOOOOOOOO\r\nYYYYYYYXYXXXXJXGYPPPPTNNNNNNNNNNNNNNNNFMPMMMMMMMMMMMEEEEDDDFFFFVVXXXEEEEEEEEEEPPPPPPPPPPPWPWWWWWWWWWWWWFFFFFFFFFFJOOPPOOOOOPOOOPPPPPPOOOOOOC\r\nYYYYYYYYYYXXJJJJJPPPPPNNNNNNNNNNNNNNNNFMMMMMMMMMMEEEEEEEEEDDDDFXVXXXXXEEEEEEEEPHPPPPPPPPPPPPWWWWWWWWWWWFFFFFFFFFFJOOPOOOOOOPOOOPPPPPPPOOOOCC\r\nYYYYYYYYQXXXJJJJPPPPPKNNNNNNNNNNNNNNNNFFJJJMMMMMMEEEEEEEEEDDDDXXXXXXXLLLEEEEEEIHHPPPPPPPPPPWWWWWWWWWWWWWYYYYJJJJJJJOOOOOOOOOOOOOPPPPPPPPOOOC\r\nYYYYYYQQQQQQJJJPPPPPRRXRRRRRRNNNNNNNNNFJJJJJMMMMMELLEEEEEEDDDDXXXXXXXLLLXEEEIIIHHPYPPPPPPPPWWWWWWWWWSWWWWYYYJJJJJJOOOOOOOOOOOPPPPPPPPPPPOOOC\r\nYYYYYNQQQQQQQJJPPPPPRRRRRRRRRRRRRRRRFFJJJJJJJJJMMYLEEEEEEDDEDEXXXXXXXLLLXEGIIIIIPPPPPPPPPPWWWWWWWWWSSWWWWYYYJJJJJOOOOOOOOOOOOPPPPPPPPPOOOOOO\r\nIYYYQQQQQQQQQJQPPPPRRRRRRRRRRRRRRRRRJJJJJJJJJJJMLLLEEEEEEEEEEEEXXXXXXLLLXXIIIIIPPPPPPPPPGPWWWWSSWWWSSSWWWYYJJJZZZZZOOOOOOOOFFFPPPPPPPPPOOOOO\r\nQQQQQQQQQQQQQQQPPPPPPPRRRRRRRRERRRRRJJJJJJJJJJJJJLLEEEEEEEEEEESSSXXXXLLLXIIIIIIIIPPPKPPPPQWSSSSSSWWSSSSSWYWWZZZZZZZZOOOOFFOFFFMPPPPPPPPPOOOO\r\nQQQQQQQQQQQQQQQPPPPEEPPEREERREEEEERJRJJJJJJJJJJJEELEEEEEEEEEESSSSSXXXLLLXIIIIIIIIZZPPZZPZZZZZSSSSSSSSSWWWWWWWZZZZZZZZFFFFFFFFFFFFFPPIPPPPOOO\r\nQPQQQQQQQQQQQQDPPEEEGEEEEEEEEEEEEEEJJJJJJJJJJJJEEEEEEEEEESEESSTSSSSXXLLLIIIIIIIIIIZPZZZZZZZZZSSSSSSSSWWWWWWWWZZZZZZZZFFFFFFFFFFFFFTOOOOOOOOO\r\nQQQQQQQQQQQQQQDDDEEEEEJTTETEEEEEEEEGJJJJJJJJEEEEEEEEEEEESSSSSSSSSSSLLLLLIIIIIIIIIIZZZZZZZZZZZZSSSSSWWWWWWWWWWZZZZZZZZFFFFFFFFFFFFFTOOOOOOOOO\r\nQQQQQQQQWWWWWQQDEEEEEEJTTTTTEEEEEEEGJJJJJJGJEEEEEEEEEEESSSSSSSSSSSSLLLLLIIIIIIIIIIZZZZZZZZZZZZSSSSWWWWWWWWWWZZZZZZZZFZFFFFFFFFFFGGOOOOOOOOOO\r\nQQQQQQQEWWWWWQQDEEEEEEJTTTTTTTEEEEEGJGJGGGGIEEEEEEIEEEESSSSSSSSSSSSLLLLLIIIIIIIIIZZZZZZZXXZZZSSSSSSSWWWWWWWZZZZZZZZFFZFFFFFFFFGGGGOOOOOOOOOO\r\nQQQQWWWWWWWWWEEEEEEEEEJJTTTTTTTTTGGGGGJGGGGIIIIIIIIEEEESSSSSSSLLLLLLLLLLIIIIIIIIIZZZZZZZXXAZZSSSSSSSSWWWWWWWWZZZZZZFFFFFFFFFFFFGGGGGOOOOOOOO\r\nQQQQWWWWWWWWWEEEEEEEEJJJTTTQRRRTGGGGGGGGGGGGIIIIIIIIIESSSSSSSSLLLLLLLLLLIIIIIIIIZZZZZZZZXXAZZSSMSSSSSWWWWWWWWZZZZZZFFFFFFFFFFFGGGOOOOOOOOOOO\r\nQQQQWWWWWWWWWEEEEEEEEEJJTRRRRRRWRGGGGGHGGGGGGGIIIIIIIEESSSSSSSLLLLLLLLLLIIIIIIIIZIZZZZXXXXMMMMSMSSSSSWWWWWWWZZZZHHHFHFGFFFFFFFFFGOOOOOOOOOOO\r\nQQQWWWWWWWWEEEEEEEEEEEEEERRRRRRRRRGGGHHGGGGIIIIIIIDDIEWSSSSSSSLLLLLLLLLLIIEEEIIIIIZZZZXXXXXMMMMMMMMSSWWWWWWZZZZZHHHHHFGFFFFFFFFFGOOOOOOOOOOO\r\nQQQWWWWWWWWEEEEEEREEEEPPERRRRRRRRGGGGHHGGGGGGIIIIIIIIEEGSSWNSSLLLLLLLLLLIEEEEIIIIIZZZXXXXXZMMMMMMMSSSWWWWWZZZZZZHHHHHFFFFFFFFFFGGOOOOOOOOOOO\r\nQQQWWWWWWWWEEEEEEEEEEEPPERRRRRRRRGGHHHHGGGGGGIIIIIIIIIEICNNNSSLLLLLLLLLLEEEEBETEIIZZZXXXXXZZMMMMMMMMMZZZZZZZZZZZHHHHHFFFFEFGGFGGGGGGOOOOOOOO\r\nLQLWWWWWWWWEEEEEEEEEEEEEEERRRRRRRRHHHHHHHGGGGIIIIIIIIIIIINNNNNNNLLLLLLLEEEEEEEEEIIZXXXXXXZZZMEEMMMMMMMMZZZZZZZZZHFFHFQFBFFFGGFGGGGGGGXXOOOOO\r\nLLLWWWWWWWWEEEEEEEEEEEEEEEERRRRRRHHHHHHHHGGIIIIIIIIIIIIIINNNNNNNLLLLLLLEEEEEEEEEZZZZZZXXXZZZMMMMMMMMMMZZZZZZZZZZFFFHFFFFFGGGGGGGGXXXGXXOOOOO\r\nLLLWWWWWWWWEEEEEEEEEEEEEEEERRRRRRRHHHHHHHHOIIIIIIIIIININNNNNNNNNLLLLLLLEEEEEEEEKUZUZZZZXZZZZMMMMMMMMMZZZZZZZZZZZFFFHFFFQQXGGGGGGGXXXXXXOOOOO\r\nLAAWWWWWWWWEEEEEEEEEEEEEERRRRRRRRFHHHHHHHHOIIIIIIIAINNNNNNNNNNNNNNYYJJJEEEEEEEEUUZUUZZZZZWWMMMMMMMMMMMMZZZZZZZZZFFFFFFXXXXXGGXXXXXXXXXXOOOOO\r\nLAAWWWWWSSSEEEEEEEEEEEEEEEERRRZHHHHHHHHHOHOOOOIIIIIIINNNNNNNNNNNNYYYYEEEEEEEEEUUKUUUUUZZZWWHHHMMMMMMMMMZZZZZZZZZFFFFFFFXXXXXXXXXXXXXXXXXXXOO\r\nLLAWWWWWSSSAAEEEEEEEEEEEXEEERRRRHHHHHHOOOOOOOOIIIINNNNNNNNNNNNNNNYYYYEEEEEEEUUUUKUUUUZZZZWHHHHHMMMMMMMMZZZZZZZZZFFFFFFFXXXXXXXXXXXXXXXXXXGGO\r\nLLAAAALLLLLAAAAAAEEEEEXXXXXXXRWWHHHHHHOOOOOOOOOIOIINNNNNNNNINNNYYYYYEEYYYYYYYYUUUUUUUZZZWWWHWHMMMXVVVVVZZZZZZZBFFFFFFFXXXXXXXXXXXXXXXXXXXGGO\r\nLLAAALLLLLAAAAAAAATAEEEXXXXXWWWWWHWWHHPPOOOOOOOOOOINNNNNNNNYNNCYYYYYYYYYYYYYYYEUUYYYZZZWWWWHWWWWMMVVVVVZZZZZZZBFFFFFFFFFBBXXXXXXXXXXXXBPPPPP\r\nAAAAAAAALLAAAAAAAAAAOOOOXXXXWXWWWWWWWOOOOOOOOOOOONNNNNNNNNNYNLYYYYYYYYYYYYYYYYUUUYYYUZZWWWWHWWDMMDVVVVVZZZZZDBBBFFFFFFFFFBXXXXXXXXXXXXBBPPPP\r\nAAAAAAAAALAAAAAAAAAAOOOOUXXXXXXWWWWWWWWOOOOOGOOOOOOONNNNNNNYYYYYYYYYYYYYYYYYYYUUUYYYUUWWWWWWWWDDMDDVVVVZZZZZDDDBFFFFFFFFBBBXXXXXXXXXXSPPPPPP\r\nAAAAAAAAAAAAAAAAAAAAOOOUUUUXXXXXWWWWWWGGOUOGGOOOOOONNNNNNGNYYYYYYYYYYYYYYYYYYYYYYYYYUWWWWWWWWWWDDDDWVVVZZZZDDDBBBBBBBBBBBBBXXXSSSSSSSSPPPPPP\r\nAAAAAAAAAAAAAAAAAAAOOOOUUUQUXNXWWWWWWWWGGGGGGGOOOOONNNNNNGGYYYYYYYYYYYYYYYYYYYYYYYYYYUWWWWWWWWWDWWWWVFDZZDDDDDBKKBBBBBBBBBBBBBBBSSSSSSSPPPPP\r\nAAAAAAAAAAAAAAAAOOOOOOOUUUUUXXWWWWWWWWGGGGGGGOOOOOOONNNGGGGYYYYYYVYYYYYYYYYYYYYYYYYYYJJPPWWWWWWWWWWWFFDDDDDDDDBKKKKBBBBBBBBBBBBBBBSSSSSSPPPP\r\nAAAAAAAAAAAAAAAAOOOOOUUUUUUUUXWWWWWWWGGGGGGGGGGOOOOOOONGGGYYYYYRYVVVVVYYYYYYYYYYYYYYYPPPWWWWWWWWWWOWFDDDDDDDDKIKKKKKKBBBBBBBBBBBSSSSSSHPPPPP\r\nAAAAAAAAAAAAAAAAOOOOUUUUUUUUUUWWWWWWWWGGGGGGGGGGOOOOOONOGGGGYUUUUUULVVYYYYYYYYYYYYYYYPPPPPWWWWWWWWOODDOOOOODDKKKKKKKKBBBBBBBBBBBSSSSHSHPHPPP\r\nAAAAAAAAAAAAAAAAOOOUUUUUUUUUUUUWWWWWWGGGGGGGGGGGOOOOOOOOGGGGYUUUUUULVVYYYYYYYYYYYYYYYPPPPPPWWWWWWLLLLLLLLLLLLLKKKKKKKBBBBBBBBBBSSSSHHHHHHHHH\r\nAAAAAAAAAAAZAAAAOOOOUUUUUUUUUUUUWWWWWGGGGGGGGGGOOOOOOOOOGGGUUUUUUUUVVVVVVXXXXXYYYYYYYPPPPPPPWWWGGLLLLLLLLLLLLLKKKKKKKKBBBBBBYBBSFFSFXHHHHHHH\r\nAAAAAAAAAAAZOOOOOOPPPPPUUUUUUBBUWWWWWWGGGGGGGGGOOOOOOOOGGGGUUUUUUUVVVVVVVXXXXXYYYYYYYPPPPPPPWWLLLLLLLLLLLLLLLLKKPKABBBBBBBBBBFBBFFSFXFLHHHHH\r\nAAAAAAAAAZZZZOOOOOPPPPPPPPVPBBWWWWWWWGGGGGGGGGGOOOOOOGGGGGUUUUUUUUVVDDDVVXXXXXYYYYYYYPPPPPPPPFLLLLLLLLLLLLLLLLDDDDDBBBBBBBBBBFFBFFFFFFLVLLLH\r\nAAAAAAZZZZZZZOOOOOPPPPPDPPPPBBWBWBWWWWWGGGGGGGLSOOOGGGGGGGGGUUUUUUUVDDDVVXXXXXYYYYYYYPPPPPPPPFLLLLLLLLLLLLLLLLDDDDDVBBBBBBBBFFFBFFFFLLLVLLPP\r\nFAAAAZZZZZZZZZOOOOPPPPPDPPPBBBBBBBWBBWGGGGGGGQLSOOOGGGGGGGGGUUUUUUUUDDDVVXXXXXXXXXXXKPKPPPPPPFLLLLLLLLLLLLLLLLDDDDVVVBBBBBJBFFFFFFFFLLLLLLPP\r\nFAAAAZZZUUZOOOOOOOPPPPPPPPPPBBBBBBBBBWWGGGGQQQLLLLGGGGGGGGGGUUUUUUUUDDDVVXXXXXXXXXKKKKKPPPPPPPLLLLLLLLLLLLLLLLDDDDVVVVVVVVVFFFFFFFFFLLLLLLPP\r\nAAZZZZUUUUUUUOOUDUPPPPPPPPPPPPPBBBBBYBBGGGGGGQQLLDGGGGGGGGGGUUUUUUUUDDDVVXXXXXXXXXKKKKPPPPPLLLLLLLLLLLLLLLPDPDDDDDDVVVVVVVVFFFFFFFFFLLLLLLPL\r\nZZZZZZUUUUUUUUUUUUPPPPPPPPPPPPPBBBBBBBBBBGGLLLLLLDDDGGGGGGGGGGZUUUUUDDDVVXXXXXXXXXKKKKKKKPPLLLLLLLLLLOOPPPPPPPODDVFFFFFVVVFFFFFFFFFFLLLLLLLL\r\nZZZZZZUUUUUUUUUUUUPPPPPPPPPPPPPPPBPBBBBBPGJLLLLLLLLDGGGGGGGGGGZZUUZZDDDVVVKKVXXXKKKKKKKKKUULLLLLFFKOOOPPPPPOOOODVVFFFFVVVVFFFFFFFFFLLLLLLLLL\r\nZZZZZZUUUUUUUUUUFFPPPPPPPPPPPPPPPPPBPEEBPLLLLLLLLLLLGGHHHGGGGGGZZZZZDDDVKKKKKKVVKKKKKKKKKUULLLLLFFKKOPPPPPPOOOODVVVVVFFFFVFMFFMMFMLLLLLLLLLL\r\nZZZUUUUUUUUUUUUUFFPPPPPPPPPPPPPPPPPBPPEPPLLLLLLLLLLHHHHHHHGGGGHZZZDDDDDDDDDDDKKVVKKSKKKKKUULLLLLFFPPPPPPPPPOOOOOVVVVVFFFFFFMMMMMMMMLLLLLLLLL\r\nZZZUUXUUUUUUUUUUFFPPPPPPPPKPPPPPPPPPPPEPWLLLLLLLLHHHHHHHHHGGGGHZZZDDDDDDDDDDDKKVKKSSSKKSSUUFUUFFFFPPPPPPPPOOOOOOVVVVVFFFFFFMMMMMMMMMMLLLDLLL\r\nZZUUZZUUUUUUUUUUFFFPPPPPKKKPPPPPPZPPPPPPPLLLLLLLLLHHHHHHHHGGGGHHZZDDDZDDDDDDDDDDDKSSSSKSSBBFUUFFFFFPPPPPOOOOOOOOVVVVVVMMMFMMMMMMMMMMMMLLDDDL\r\nZZZZZUUBUUUUUUUUUUFFPKKKKKKKKPPPPZZPPPMMLLLLLLLHLHHHHHHHHHCCGGHHHZZZZZZZDDDDDDDDDKSSSSSSSSBFFFFFFFFFFSPPOOOOOOOOVVVVVVVVMMMMMMMMMMMMMDLDDDLL\r\nZZZZZUBBBUUUUUUUHHTFFKKKKKKKPPPPZZZZZPMDDLLLLLLHHHHHHHHHHHHHHHHHHZZZZZZZDDDDDDDDDSSSSSSSSBBFFFFFFFFFFFFROOOOOVVVVVVVVVVVDMMMMMMMMMMMMDDDDDLD\r\nZZZZUUBBBBUUUUHHHTTTTTTKKKKKKKKZZZZZZDDDALLLLLLLHHHHHHHHHHHHHHHZHZZZZZZZDDDDDDDDDSSSSSSSSSBFFFFFOFFFFFRROOOOVVVVVVVVVVDDDDDMMMMMMMMMMDDDDDDD\r\nZZZZZZZBBUUUUUHTTTTTTTTKKKKKKKZZZZZZZDDDALLLLLLHHHHHHHHHHHHHHHHZZZZZZZZZDDDDDDDDDKSSSSSSSFFFFFFFFWWWFWRVVVVOVVVVVVVVVLLDDDDMMMMMMMDDDDDDDDDD\r\nZZZZRZBBBBBBUTHTTTTTTTDDDKKKKBBZZZZZWWDDALLLLLLLHHHHHHHHHHHHHHZZZZZZZZZZDDDDDDDDDKKSXSSSSXAFWWFWWWWWFWWVVVVVVVVVVVVVKLLDDDDDMMMMMMMDYDDDDDDD\r\nZZRRRBBBBBBBBTTTTTTTTTDKKKKBBBZZTZZZZZDDLLLLLLLLLLHHHHHHHHHHHHZZZZZZZZZZDDDDDDDDDKKSXXXXXXAAAAAWQQWWWWWVVVVVVVVVVVVVKLLDDDDDDDMDMMQDDDDDDDDD\r\nZZZRRRBBBBBBBTTTTTTTTTDDKKKBBTTZTTZTZDDDDLLLLLLLLLLHHHHHHDDHHZZZZZPZZZZZDDDDDDDDDKKKKXXXXAAAAAWWWQQWWWWVVVVVVVVVVVKKKKLDDDDDDDJDDDQDDDDDDDDD\r\nZZZRRRBBBBBBBBTTTTTTTTDTBKKBBBTZTTZTTTTTTTTLLLLLLLUUUHHHHDDHHZZZZPPZZZZZZZZZKDDDDKKKKXXQAAAAQQQWWQQQQWWVVVVVVVVKYVKKKLLDDDDDDDDDDDDDDDDDDDDD\r\nZZZRRRBBBBBBBBBTTBTTTTTTBXBBBBTTTTTTTTTTTTTLLLLLLLUUHHHHDDDDHZZZZZPPPZPZDDDDDDDDDDDDXXQQQAAQQQQQQQQQQWWWVVVSVVSKKKKDDDDKDDDDDDDDDDDDDDDDDDDD\r\nZYRRRRRRBBBBBBBBBOTQTTTBXXXBBXTTTTTPTPTTTTVRLLLLLLUUHHHHDDDDZZZZZZAPPPPPDDDDDDDDDDDDDQQQQQAQQQQQQQQQQWWWVVVSSSSKKKKKDDDDDDDDDDDDDDUDDDDDDDDD\r\nRYRRRRRBBBBBBBBBBOOOXXXXXXXXXXTTTTTPTPTTTVVVLLLLUUUUUUUHDDMMZZZZZPPPPPPPDDDDDDDDDDDDVQQQQQQQQQQQQQQQQWWWVVZZZKKKKKKKKNDUDDDDDDDDDDUDDDDDDDDD\r\nRRRRRRRRBRRBBBBOOOOOXXXXXXXXXTTTTTTPPPVVVVVCLLCUUUUUUUUUUDMMZZZZZPPPPPPPDDDDDDDDDDDDVQQQQQQQQQQQQQQQWWWZZZZZZZZKKKKKNNDDDDDDDDDDDDUUDDSDSSDD\r\nRRRRRRRRRRRRRBBOOOOOMXXXXXXXXTTTTTPPPPCCCCVCLLCUUUUUUUUUUMMPZPPPPPPPPPPPDDDDDDDDDDDDDQQQQQQQQQQQQQQQWWZZZZZZZZNKKKKKNDDDDPPDDDDDDDUUUSSSSSDD\r\nRRRRRRRRRRRRRBOOOOOOXXXXXXXXXTTTPPPPPPCCPCCCCCCCUUUUUUUUMMMPPPPPPPPPPPPPDDDDDDDDDDDDGQQQQQQQQQQQQQQGWWWWZZZZZZNNNNNNNNNDPPPPDDDDDDUUUUSSSDDD\r\nRRRRRRRRRRRRRROOOOOOXXXXXXXXXXQPPPPPPPPPPPPPPPCCUUUUUUUUMMMPPPPPPPPPPPPPDDDDDDDDDDDGGQQGQQQQQQQQQQQGGWWWZZZZZZNNNNNNNNNDDPPPPDDDDUUUUUSSSSSD\r\nRRRRRRRRRROROOOOOOOXXXXXXXXXXXXXPPPPPPPPPPPPCCCCUUUUUMMMMMMMPPPPPPPPPPPPPPPPPPDDDDDDGGGGGQQQQQQQQQGGGGGGGZZZZZZNNNNNNNNPPPPPPDDADUUUUUUSSSSS\r\nRRRRRRRRROOOOOOOOOXXXXXXXXXXXXXXPPPPPPPPPPPPCCCCCUUUMMMMMMMPPPPPPPPPPPPPPPPPPPDDDDDDGGGQDQQQQQQQQGGGGLGLGGZZZZZNNNNNNNPPPPPPPAAAUUUUUUUSSSSS\r\nRRRRRRRROOOOOOOOOOXXXWXXXXXXXXUPPPPPPPPPPPPPPCCCUUUMMMMMMMMPPPPPPPPPPPPPPPPPPPDDDDDGGGGQQQQQGQQGQQGGGGGGGGZZZZZNNNNNNNPPPPPPPAAAUUUUUUUSSSSS\r\nRRRRROOOOOOOOOOOOOOXOOOXXXXXXXUUPPPPPPPPPPPPCCCCCUCCMMMMMMMMPPPPPPPPPPPPPPGGPDDDDDDDGGGQGGQGGGGGQQQGGGGGGGGZZZZNNNNNNNNNNPNPAAAUUUUUUUUSSSSS\r\nUROOOOOOOOOOOOOOOOOOOOOXUUXXXUUUPPPPPPPPPPPPPPPCCCCCMMMMMMMPPPPPPPPPPPPPPPGGDDDDDDDDDGGGGGQGGGGGQGGGGGGGGGGZZZNNNNNNNNNNNNNPAAAUUUUUSSSSSSSS\r\nRROOOOOOOOOOOOOOOOOOOOOXUUXXUUUPPPPPPPPPPPPPPPCCCCCCCCCCMPPPPPPPPPPPPOPPPPPGGDDDDDZDDDDGGGGGGGGGGGGGGGGGGZZZZZNNNNNNNNNNNNNPAAAUUUUUSSSSSSSS";
            //string puzzle = "RRRRIICCFF\r\nRRRRIICCCF\r\nVVRRRCCFFF\r\nVVRCCCJFFF\r\nVVVVCJJCFE\r\nVVIVCCJJEE\r\nVVIIICJJEE\r\nMIIIIIJJEE\r\nMIIISIJEEE\r\nMMMISSJEEE";
            //string puzzle = "OOOOO\r\nOXOXO\r\nOXXXO";

            int cost = 0;

            List<List<string>> puzzleMap = new List<List<string>>();
            foreach (string line in puzzle.Split("\r\n"))
            {
                puzzleMap.Add(line.Select(x => x.ToString()).ToList());
            }

            int[][] directions = new int[][]
            {
    new int[] { 0, 1 },
    new int[] { 0, -1 },
    new int[] { 1, 0 },
    new int[] { -1, 0 }
            };


            for (int y = 0; y < puzzleMap.Count; y++)
            {
                for (int x = 0; x < puzzleMap[y].Count; x++)
                {
                    //Comprobar si esta posicion ya fue revisada
                    if (puzzleMap[y][x] != "*")
                    {
                        List<int[]> parcelPositions = new List<int[]>();
                        parcelPositions.Add(new int[] { y, x });
                        List<int[][]> parcelSides = new List<int[][]>();
                        string thisLetter = puzzleMap[y][x];


                        for (global::System.Int32 i = 0; i < parcelPositions.Count; i++)
                        {
                            foreach (var item in directions)
                            {
                                int[] nearPosition = new int[] { parcelPositions[i][0] + item[0], parcelPositions[i][1] + item[1] };
                                //Evitar salirse del mapa
                                if (nearPosition[0] < 0 || nearPosition[0] >= puzzleMap.Count || nearPosition[1] < 0 || nearPosition[1] >= puzzleMap[nearPosition[0]].Count)
                                {
                                    //Cuardar el lado de la parcela
                                    parcelSides.Add([nearPosition, parcelPositions[i]]);
                                    continue;
                                }
                                //Comprobar si la posicion es parte de la parcela
                                if (puzzleMap[nearPosition[0]][nearPosition[1]] == thisLetter)
                                {
                                    if (parcelPositions.Any(x => x.SequenceEqual(nearPosition)))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        parcelPositions.Add(nearPosition);
                                    }
                                }
                                else
                                {
                                    parcelSides.Add([nearPosition, parcelPositions[i]]);
                                }
                            }
                        }
                        //Ahora hay que hacer criba de los lados
                        for (int sideIdx = 0; sideIdx < parcelSides.Count; sideIdx++)
                        {
                            int[] direction = [parcelSides[sideIdx][0][1] - parcelSides[sideIdx][1][1], parcelSides[sideIdx][0][0] - parcelSides[sideIdx][1][0]];
                            //Direction1
                            for (int i = 1; i < Int32.MaxValue; i++)
                            {
                                int[][] direction1 = [[parcelSides[sideIdx][0][0] - (direction[0] * i), parcelSides[sideIdx][0][1] - (direction[1] * i)], [parcelSides[sideIdx][1][0] - (direction[0] * i), parcelSides[sideIdx][1][1] - (direction[1] * i)]];
                                int findedIndex = parcelSides.FindIndex(x => x[0].SequenceEqual(direction1[0]) && x[1].SequenceEqual(direction1[1]));
                                if (findedIndex != -1)
                                {
                                    parcelSides.RemoveAt(findedIndex);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            //Direction2
                            for (int i = 1; i < Int32.MaxValue; i++)
                            {
                                int[][] direction1 = [[parcelSides[sideIdx][0][0] + (direction[0] * i), parcelSides[sideIdx][0][1] + (direction[1] * i)], [parcelSides[sideIdx][1][0] + (direction[0] * i), parcelSides[sideIdx][1][1] + (direction[1] * i)]];
                                int findedIndex = parcelSides.FindIndex(x => x[0].SequenceEqual(direction1[0]) && x[1].SequenceEqual(direction1[1]));
                                if (findedIndex != -1)
                                {
                                    parcelSides.RemoveAt(findedIndex);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        };
                        //Console.WriteLine($"Parcela de {thisLetter} con {parcelPositions.Count} posiciones, lados {parcelSides.Count}");
                        cost += parcelPositions.Count * parcelSides.Count;

                        //Transformar estas posiciones en *
                        parcelPositions.ForEach(x => puzzleMap[x[0]][x[1]] = "*");
                    }
                }
            }

            Console.WriteLine($"Costo total: {cost}");
        }
    }
}
