// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  struct InnerTransactionResult
//  {
//      // Always 0. Here for binary compatibility.
//      int64 feeCharged;
//  
//      union switch (TransactionResultCode code)
//      {
//      // txFEE_BUMP_INNER_SUCCESS is not included
//      case txSUCCESS:
//      case txFAILED:
//          OperationResult results<>;
//      case txTOO_EARLY:
//      case txTOO_LATE:
//      case txMISSING_OPERATION:
//      case txBAD_SEQ:
//      case txBAD_AUTH:
//      case txINSUFFICIENT_BALANCE:
//      case txNO_ACCOUNT:
//      case txINSUFFICIENT_FEE:
//      case txBAD_AUTH_EXTRA:
//      case txINTERNAL_ERROR:
//      case txNOT_SUPPORTED:
//          // txFEE_BUMP_INNER_FAILED is not included
//          void;
//      }
//      result;
//  
//      // reserved for future use
//      union switch (int v)
//      {
//      case 0:
//          void;
//      }
//      ext;
//  };
//  ===========================================================================
    public class InnerTransactionResult
    {
        public InnerTransactionResult()
        {
        }

        public Int64 FeeCharged { get; set; }
        public InnerTransactionResultResult Result { get; set; }
        public InnerTransactionResultExt Ext { get; set; }

        public static void Encode(XdrDataOutputStream stream, InnerTransactionResult encodedInnerTransactionResult)
        {
            Int64.Encode(stream, encodedInnerTransactionResult.FeeCharged);
            InnerTransactionResultResult.Encode(stream, encodedInnerTransactionResult.Result);
            InnerTransactionResultExt.Encode(stream, encodedInnerTransactionResult.Ext);
        }

        public static InnerTransactionResult Decode(XdrDataInputStream stream)
        {
            InnerTransactionResult decodedInnerTransactionResult = new InnerTransactionResult();
            decodedInnerTransactionResult.FeeCharged = Int64.Decode(stream);
            decodedInnerTransactionResult.Result = InnerTransactionResultResult.Decode(stream);
            decodedInnerTransactionResult.Ext = InnerTransactionResultExt.Decode(stream);
            return decodedInnerTransactionResult;
        }

        public class InnerTransactionResultResult
        {
            public InnerTransactionResultResult()
            {
            }

            public TransactionResultCode Discriminant { get; set; } = new TransactionResultCode();
            public OperationResult[] Results { get; set; }

            public static void Encode(XdrDataOutputStream stream,
                InnerTransactionResultResult encodedInnerTransactionResultResult)
            {
                stream.WriteInt((int) encodedInnerTransactionResultResult.Discriminant.InnerValue);
                switch (encodedInnerTransactionResultResult.Discriminant.InnerValue)
                {
                    case TransactionResultCode.TransactionResultCodeEnum.txSUCCESS:
                    case TransactionResultCode.TransactionResultCodeEnum.txFAILED:
                        int resultssize = encodedInnerTransactionResultResult.Results.Length;
                        stream.WriteInt(resultssize);
                        for (int i = 0; i < resultssize; i++)
                        {
                            OperationResult.Encode(stream, encodedInnerTransactionResultResult.Results[i]);
                        }

                        break;
                    case TransactionResultCode.TransactionResultCodeEnum.txTOO_EARLY:
                    case TransactionResultCode.TransactionResultCodeEnum.txTOO_LATE:
                    case TransactionResultCode.TransactionResultCodeEnum.txMISSING_OPERATION:
                    case TransactionResultCode.TransactionResultCodeEnum.txBAD_SEQ:
                    case TransactionResultCode.TransactionResultCodeEnum.txBAD_AUTH:
                    case TransactionResultCode.TransactionResultCodeEnum.txINSUFFICIENT_BALANCE:
                    case TransactionResultCode.TransactionResultCodeEnum.txNO_ACCOUNT:
                    case TransactionResultCode.TransactionResultCodeEnum.txINSUFFICIENT_FEE:
                    case TransactionResultCode.TransactionResultCodeEnum.txBAD_AUTH_EXTRA:
                    case TransactionResultCode.TransactionResultCodeEnum.txINTERNAL_ERROR:
                    case TransactionResultCode.TransactionResultCodeEnum.txNOT_SUPPORTED:
                        break;
                }
            }

            public static InnerTransactionResultResult Decode(XdrDataInputStream stream)
            {
                InnerTransactionResultResult decodedInnerTransactionResultResult = new InnerTransactionResultResult();
                TransactionResultCode discriminant = TransactionResultCode.Decode(stream);
                decodedInnerTransactionResultResult.Discriminant = discriminant;
                switch (decodedInnerTransactionResultResult.Discriminant.InnerValue)
                {
                    case TransactionResultCode.TransactionResultCodeEnum.txSUCCESS:
                    case TransactionResultCode.TransactionResultCodeEnum.txFAILED:
                        int resultssize = stream.ReadInt();
                        decodedInnerTransactionResultResult.Results = new OperationResult[resultssize];
                        for (int i = 0; i < resultssize; i++)
                        {
                            decodedInnerTransactionResultResult.Results[i] = OperationResult.Decode(stream);
                        }

                        break;
                    case TransactionResultCode.TransactionResultCodeEnum.txTOO_EARLY:
                    case TransactionResultCode.TransactionResultCodeEnum.txTOO_LATE:
                    case TransactionResultCode.TransactionResultCodeEnum.txMISSING_OPERATION:
                    case TransactionResultCode.TransactionResultCodeEnum.txBAD_SEQ:
                    case TransactionResultCode.TransactionResultCodeEnum.txBAD_AUTH:
                    case TransactionResultCode.TransactionResultCodeEnum.txINSUFFICIENT_BALANCE:
                    case TransactionResultCode.TransactionResultCodeEnum.txNO_ACCOUNT:
                    case TransactionResultCode.TransactionResultCodeEnum.txINSUFFICIENT_FEE:
                    case TransactionResultCode.TransactionResultCodeEnum.txBAD_AUTH_EXTRA:
                    case TransactionResultCode.TransactionResultCodeEnum.txINTERNAL_ERROR:
                    case TransactionResultCode.TransactionResultCodeEnum.txNOT_SUPPORTED:
                        break;
                }

                return decodedInnerTransactionResultResult;
            }
        }

        public class InnerTransactionResultExt
        {
            public InnerTransactionResultExt()
            {
            }

            public int Discriminant { get; set; } = new int();

            public static void Encode(XdrDataOutputStream stream,
                InnerTransactionResultExt encodedInnerTransactionResultExt)
            {
                stream.WriteInt((int) encodedInnerTransactionResultExt.Discriminant);
                switch (encodedInnerTransactionResultExt.Discriminant)
                {
                    case 0:
                        break;
                }
            }

            public static InnerTransactionResultExt Decode(XdrDataInputStream stream)
            {
                InnerTransactionResultExt decodedInnerTransactionResultExt = new InnerTransactionResultExt();
                int discriminant = stream.ReadInt();
                decodedInnerTransactionResultExt.Discriminant = discriminant;
                switch (decodedInnerTransactionResultExt.Discriminant)
                {
                    case 0:
                        break;
                }

                return decodedInnerTransactionResultExt;
            }
        }
    }
}