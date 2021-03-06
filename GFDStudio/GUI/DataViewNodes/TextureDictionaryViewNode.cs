﻿using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GFDLibrary;
using Ookii.Dialogs;

namespace GFDStudio.GUI.DataViewNodes
{
    public class TextureDictionaryViewNode : ResourceViewNode<TextureDictionary>
    {
        public override DataViewNodeMenuFlags ContextMenuFlags =>
            DataViewNodeMenuFlags.Export | DataViewNodeMenuFlags.Replace | DataViewNodeMenuFlags.Move |
            DataViewNodeMenuFlags.Delete | DataViewNodeMenuFlags.Add;

        public override DataViewNodeFlags NodeFlags => DataViewNodeFlags.Branch;

        protected internal TextureDictionaryViewNode( string text, TextureDictionary data ) : base( text, data )
        {
        }

        protected override void InitializeCore()
        {
            RegisterExportHandler<TextureDictionary>( path => Data.Save(  path ) );
            RegisterReplaceHandler<TextureDictionary>( Resource.Load<TextureDictionary> );

            RegisterAddHandler< Bitmap >( path => Data.Add( TextureEncoder.Encode( Path.GetFileNameWithoutExtension( path ) + ".dds", 
                TextureFormat.DDS, new Bitmap( path ) ) ) );

            RegisterAddHandler< Stream >( path => Data.Add( new Texture( Path.GetFileNameWithoutExtension( path ) + ".dds", 
                TextureFormat.DDS, File.ReadAllBytes( path ) ) ) );

            RegisterModelUpdateHandler( () =>
            {
                var textureDictionary = new TextureDictionary( Version );
                foreach ( TextureViewNode textureAdapter in Nodes )
                {
                    textureDictionary[textureAdapter.Name] = textureAdapter.Data;
                }

                return textureDictionary;
            } );

            RegisterCustomHandler( "Convert to field texture archive", () =>
            {
                using ( var dialog = new SaveFileDialog() )
                {
                    dialog.Filter = "Field Texture Archive (*.bin)|*.bin";
                    dialog.AutoUpgradeEnabled = true;
                    dialog.CheckPathExists = true;
                    dialog.FileName = Text;
                    dialog.OverwritePrompt = true;
                    dialog.Title = "Select a file to export to.";
                    dialog.ValidateNames = true;
                    dialog.AddExtension = true;

                    if ( dialog.ShowDialog() != DialogResult.OK )
                        return;

                    Replace( TextureDictionary.ConvertToFieldTextureArchive( Data, dialog.FileName ) );
                }
            } );

            RegisterCustomHandler( "Export All", () =>
            {
                using ( var dialog = new VistaFolderBrowserDialog() )
                {
                    if ( dialog.ShowDialog() != DialogResult.OK )
                        return;

                    foreach ( TextureViewNode viewModel in Nodes )
                        File.WriteAllBytes( Path.Combine( dialog.SelectedPath, viewModel.Text ), viewModel.Data.Data );
                }
            } );
        }

        protected override void InitializeViewCore()
        {
            foreach ( var texture in Data.Textures )
            {
                var node = DataViewNodeFactory.Create( texture.Name, texture );
                Nodes.Add( node );
            }
        }
    }
}
