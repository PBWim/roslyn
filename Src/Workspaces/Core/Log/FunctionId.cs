﻿// Copyright (c) Microsoft Open Technologies, Inc.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.Internal.Log
{
    /// <summary>
    /// Enum to uniquely identify each function location.
    /// </summary>
    internal enum FunctionId
    {
        // a value to use in unit tests that won't interfere with reporting
        // for our other scenarios.
        TestEvent_NotUsed,

        Tagger_AdornmentManager_OnLayoutChanged = 1,
        Tagger_AdornmentManager_UpdateInvalidSpans,
        Tagger_BatchChangeNotifier_NotifyEditorNow,
        Tagger_BatchChangeNotifier_NotifyEditor,
        Tagger_TagSource_RecomputeTags,
        Tagger_TagSource_ProcessNewTags,
        Tagger_SyntacticClassification_TagComputer_GetTags,
        Tagger_SemanticClassification_TagProducer_ProduceTags,
        Tagger_BraceHighlighting_TagProducer_ProduceTags,
        Tagger_LineSeparator_TagProducer_ProduceTags,
        Tagger_Outlining_TagProducer_ProduceTags,
        Tagger_Highlighter_TagProducer_ProduceTags,
        Tagger_ReferenceHighlighting_TagProducer_ProduceTags,

        CaseCorrection_CaseCorrect,
        CaseCorrection_ReplaceTokens,
        CaseCorrection_AddReplacements,

        CodeCleanup_CleanupAsync,
        CodeCleanup_Cleanup,
        CodeCleanup_IterateAllCodeCleanupProviders,
        CodeCleanup_IterateOneCodeCleanup,

        CommandHandler_GetCommandState,
        CommandHandler_ExecuteHandlers,

        Workspace_SourceText_GetChangeRanges,
        Workspace_Recoverable_RecoverRootAsync,
        Workspace_Recoverable_RecoverRoot,
        Workspace_Recoverable_RecoverTextAsync,
        Workspace_Recoverable_RecoverText,
        Workspace_SkeletonAssembly_GetMetadataOnlyImage,
        Workspace_SkeletonAssembly_EmitMetadataOnlyImage,
        Workspace_Document_State_FullyParseSyntaxTree,
        Workspace_Document_State_IncrementallyParseSyntaxTree,
        Workspace_Document_GetSemanticModel,
        Workspace_Document_GetSyntaxTree,
        Workspace_Document_GetTextChanges,
        Workspace_Project_GetCompilation,
        Workspace_Project_CompilationTracker_BuildCompilationAsync,
        Workspace_ApplyChanges,
        Workspace_TryGetDocument,
        Workspace_TryGetDocumentFromInProgressSolution,

        EndConstruct_DoStatement,
        EndConstruct_XmlCData,
        EndConstruct_XmlComment,
        EndConstruct_XmlElement,
        EndConstruct_XmlEmbeddedExpression,
        EndConstruct_XmlProcessingInstruction,

        FindReference_Rename,
        FindReference_ChangeSignature,
        FindReference,
        FindReference_DetermineAllSymbolsAsync,
        FindReference_CreateProjectMapAsync,
        FindReference_CreateDocumentMapAsync,
        FindReference_ProcessAsync,
        FindReference_ProcessProjectAsync,
        FindReference_ProcessDocumentAsync,

        LineCommit_CommitRegion,

        Formatting_TokenStreamConstruction,
        Formatting_ContextInitialization,
        Formatting_Format,
        Formatting_ApplyResultToBuffer,
        Formatting_IterateNodes,
        Formatting_CollectIndentBlock,
        Formatting_CollectSuppressOperation,
        Formatting_CollectAlignOperation,
        Formatting_CollectAnchorOperation,
        Formatting_CollectTokenOperation,
        Formatting_BuildContext,
        Formatting_ApplySpaceAndLine,
        Formatting_ApplyAnchorOperation,
        Formatting_ApplyAlignOperation,
        Formatting_AggregateCreateTextChanges,
        Formatting_AggregateCreateFormattedRoot,
        Formatting_CreateTextChanges,
        Formatting_CreateFormattedRoot,

        SmartIndentation_Start,
        SmartIndentation_OpenCurly,
        SmartIndentation_CloseCurly,

        Rename_InlineSession,
        Rename_FindLinkedSpans,
        Rename_GetSymbolRenameInfo,
        Rename_OnTextBufferChanged,
        Rename_ApplyReplacementText,
        Rename_CommitCore,
        Rename_CommitCoreWithPreview,
        Rename_GetAsynchronousLocationsSource,
        Rename_AllRenameLocations,
        Rename_StartSearchingForSpansInAllOpenDocuments,
        Rename_StartSearchingForSpansInOpenDocument,
        Rename_CreateOpenTextBufferManagerForAllOpenDocs,
        Rename_CreateOpenTextBufferManagerForAllOpenDocument,
        Rename_ReportSpan,
        Rename_GetNoChangeConflictResolution,
        Rename_Tracking_BufferChanged,

        TPLTask_TaskScheduled,
        TPLTask_TaskStarted,
        TPLTask_TaskCompleted,

        CodeHierarchy_SearchForField,
        CodeHierarchy_FindMethodOrPropertyOrEventImplements,
        CodeHierarchy_FindMethodOrPropertyOrEventImplementedBy,
        CodeHierarchy_FindMethodOrPropertyOrEventOverrides,
        CodeHierarchy_FindMethodOrPropertyOrEventOverriddenBy,
        CodeHierarchy_FindMethodOrPropertyOrEventCallers,
        CodeHierarchy_SearchForMethodOrPropertyOrEvent,
        CodeHierarchy_SearchForNamedType,
        CodeHierarchy_SearchForNamedTypeParts,
        CodeHierarchy_SearchForNamedTypeImplements,
        CodeHierarchy_SearchForNamedTypeImplementedBy,
        CodeHierarchy_SearchForNamedTypeInherits,
        CodeHierarchy_SearchForNamedTypeInheritedBy,

        QuickInfo_ModelComputation_ComputeModelInBackground,

        Completion_ModelComputer_DoInBackground,
        Completion_ModelComputation_FilterModelInBackground,
        Completion_ModelComputation_WaitForModel,
        Completion_SymbolCompletionProvider_GetItemsWorker,
        Completion_KeywordCompletionProvider_GetItemsWorker,
        Completion_SnippetCompletionProvider_GetItemsWorker_CSharp,

        SignatureHelp_ModelComputation_ComputeModelInBackground,
        SignatureHelp_ModelComputation_UpdateModelInBackground,

        Refactoring_CodeRefactoringService_GetRefactoringsAsync,
        Refactoring_AddImport,
        Refactoring_FullyQualify,
        Refactoring_GenerateFromMembers_AddConstructorParameters,
        Refactoring_GenerateFromMembers_GenerateConstructor,
        Refactoring_GenerateFromMembers_GenerateEqualsAndGetHashCode,
        Refactoring_GenerateMember_GenerateConstructor,
        Refactoring_GenerateMember_GenerateDefaultConstructors,
        Refactoring_GenerateMember_GenerateEnumMember,
        Refactoring_GenerateMember_GenerateMethod,
        Refactoring_GenerateMember_GenerateVariable,
        Refactoring_ImplementAbstractClass,
        Refactoring_ImplementInterface,
        Refactoring_IntroduceVariable,
        Refactoring_GenerateType,
        Refactoring_RemoveUnnecessaryImports_CSharp,
        Refactoring_RemoveUnnecessaryImports_VisualBasic,

        Snippet_OnBeforeInsertion,
        Snippet_OnAfterInsertion,

        Misc_NonReentrantLock_BlockingWait,
        Misc_VisualStudioWaitIndicator_Wait,
        Misc_SaveEventsSink_OnBeforeSave,

        TaskList_Refresh,
        TaskList_NavigateTo,

        WinformDesigner_GenerateXML,

        NavigateTo_Search,

        NavigationService_VSDocumentNavigationService_NavigateTo,

        NavigationBar_ComputeModelAsync,
        NavigationBar_ItemService_GetMembersInTypes_CSharp,
        NavigationBar_ItemService_GetTypesInFile_CSharp,
        NavigationBar_UpdateDropDownsSynchronously_WaitForModel,
        NavigationBar_UpdateDropDownsSynchronously_WaitForSelectedItemInfo,

        EventHookup_Determine_If_Event_Hookup,
        EventHookup_Generate_Handler,
        EventHookup_Type_Char,

        Cache_Created,
        Cache_AddOrAccess,
        Cache_Remove,
        Cache_Evict,
        Cache_EvictAll,
        Cache_ItemRank,

        TextStructureNavigator_GetExtentOfWord,
        TextStructureNavigator_GetSpanOfEnclosing,
        TextStructureNavigator_GetSpanOfFirstChild,
        TextStructureNavigator_GetSpanOfNextSibling,
        TextStructureNavigator_GetSpanOfPreviousSibling,

        Debugging_LanguageDebugInfoService_GetDataTipSpanAndText,
        Debugging_VsLanguageDebugInfo_ValidateBreakpointLocation,
        Debugging_VsLanguageDebugInfo_GetProximityExpressions,
        Debugging_VsLanguageDebugInfo_ResolveName,
        Debugging_VsLanguageDebugInfo_GetNameOfLocation,
        Debugging_VsLanguageDebugInfo_GetDataTipText,
        Debugging_EncSession,
        Debugging_EncSession_EditSession,
        Debugging_EncSession_EditSession_EmitDeltaErrorId,
        Debugging_EncSession_EditSession_RudeEdit,

        Simplifier_ReduceAsync,
        Simplifier_ExpandNode,
        Simplifier_ExpandToken,

        ForegroundNotificationService_Processed,
        ForegroundNotificationService_NotifyOnForeground,

        BackgroundCompiler_BuildCompilationsAsync,

        PersistenceService_ReadAsync,
        PersistenceService_WriteAsync,
        PersistenceService_ReadAsyncFailed,
        PersistenceService_WriteAsyncFailed,
        PersistenceService_Initialization,

        TemporaryStorageServiceFactory_ReadText,
        TemporaryStorageServiceFactory_WriteText,
        TemporaryStorageServiceFactory_ReadStream,
        TemporaryStorageServiceFactory_WriteStream,

        WorkCoordinator_DocumentWorker_Enqueue,
        WorkCoordinator_ProcessProjectAsync,
        WorkCoordinator_ProcessDocumentAsync,
        WorkCoordinator_SemanticChange_Enqueue,
        WorkCoordinator_SemanticChange_EnqueueFromMember,
        WorkCoordinator_SemanticChange_EnqueueFromType,
        WorkCoordinator_SemanticChange_FullProjects,
        WorkCoordinator_Project_Enqueue,
        WorkCoordinator_AsyncWorkItemQueue_LastItem,
        WorkCoordinator_AsyncWorkItemQueue_FirstItem,

        Diagnostics_SyntaxDiagnostic,
        Diagnostics_SemanticDiagnostic,
        Diagnostics_ProjectDiagnostic,
        Diagnostics_DocumentReset,
        Diagnostics_DocumentOpen,
        Diagnostics_RemoveDocument,
        Diagnostics_RemoveProject,

        // currently no one uses these
        SmartTags_RefreshSession,
        SmartTags_SmartTagInitializeFixes,
        SmartTags_ApplyQuickFix,

        EditorTestApp_RefreshTask,
        EditorTestApp_UpdateDiagnostics,
    }
}