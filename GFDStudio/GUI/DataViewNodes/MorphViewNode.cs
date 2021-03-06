using GFDLibrary;

namespace GFDStudio.GUI.DataViewNodes
{
    public class MorphViewNode : DataViewNode<Morph>
    {
        public override DataViewNodeMenuFlags ContextMenuFlags
            => DataViewNodeMenuFlags.Delete | DataViewNodeMenuFlags.Move | DataViewNodeMenuFlags.Export;

        public override DataViewNodeFlags NodeFlags
            => DataViewNodeFlags.Leaf;

        public int TargetCount => Data.TargetCount;

        public int[] TargetInts
        {
            get => Data.TargetInts;
            set => SetDataProperty( value );
        }

        public string MaterialName
        {
            get => Data.MaterialName;
            set => SetDataProperty( value );
        }

        public MorphViewNode( string text, Morph data ) : base( text, data )
        {
        }

        protected override void InitializeCore()
        {
            RegisterExportHandler<Morph>( path => Data.Save( path ) );
            RegisterReplaceHandler<Morph>( Resource.Load<Morph> );
        }

        protected override void InitializeViewCore()
        {
        }
    }
}