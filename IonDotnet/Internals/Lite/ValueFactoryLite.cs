﻿using System;
using System.Collections.Generic;

namespace IonDotnet.Internals.Lite
{
    internal abstract class ValueFactoryLite : IPrivateValueFactory
    {
        private ContainerlessContext _context;

        protected ValueFactoryLite(ContainerlessContext context)
        {
            _context = context;
        }


        public T Clone<T>(T value) where T : IIonValue
        {
            throw new NotImplementedException();
        }

        public IIonBlob NewNullBlob()
        {
            throw new NotImplementedException();
        }

        public IIonBlob NewBlob(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public IIonBlob NewBlob(ArraySegment<byte> bytes)
        {
            throw new NotImplementedException();
        }

        public IIonBlob NewBlob(Span<byte> bytes)
        {
            throw new NotImplementedException();
        }

        public IIonBool NewNullBool() => new IonBoolLite(_context, true);

        public IIonBool NewBool(bool value)
        {
            var ionBool = new IonBoolLite(_context, false)
            {
                BooleanValue = value
            };
            return ionBool;
        }

        public IIonClob NewNullClob()
        {
            throw new NotImplementedException();
        }

        public IIonClob NewClob(byte[] data)
        {
            throw new NotImplementedException();
        }

        public IIonClob NewClob(ArraySegment<byte> data)
        {
            throw new NotImplementedException();
        }

        public IIonClob NewClob(Span<byte> data)
        {
            throw new NotImplementedException();
        }

        public IIonDecimal NewNullDecimal()
        {
            throw new NotImplementedException();
        }

        public IIonDecimal NewDecimal(decimal value)
        {
            throw new NotImplementedException();
        }

        public IIonDecimal NewDecimal(long value)
        {
            throw new NotImplementedException();
        }

        public IIonDecimal NewDecimal(double value)
        {
            throw new NotImplementedException();
        }

        public IIonFloat NewNullFloat()
        {
            throw new NotImplementedException();
        }

        public IIonFloat NewFloat(double value)
        {
            throw new NotImplementedException();
        }

        public IIonFloat NewFloat(long value)
        {
            throw new NotImplementedException();
        }

        public IIonInt NewNullInt()
        {
            throw new NotImplementedException();
        }

        public IIonInt NewInt(int value)
        {
            throw new NotImplementedException();
        }

        public IIonInt NewInt(long value)
        {
            throw new NotImplementedException();
        }

        public IIonList NewNullList()
        {
            throw new NotImplementedException();
        }

        public IIonList NewEmptyList()
        {
            throw new NotImplementedException();
        }

        public IIonList NewList(IIonSequence children)
        {
            throw new NotImplementedException();
        }

        public IIonList NewList(params IIonValue[] children)
        {
            throw new NotImplementedException();
        }

        public IIonList NewList(IEnumerable<int> values)
        {
            throw new NotImplementedException();
        }

        public IIonList NewList(IEnumerable<long> values)
        {
            throw new NotImplementedException();
        }

        public IIonNull NewNull() => new IonNullLite(_context);

        public IIonValue NewNull(IonType type)
        {
            throw new NotImplementedException();
        }

        public IIonValue NewNullString()
        {
            throw new NotImplementedException();
        }

        public IIonValue NewString(string value)
        {
            throw new NotImplementedException();
        }

        public IIonValue NewString(Span<char> value)
        {
            throw new NotImplementedException();
        }

        public IIonStruct NewNullStruct()
        {
            throw new NotImplementedException();
        }

        public IIonStruct NewStruct()
        {
            throw new NotImplementedException();
        }

        public IIonSymbol NewNullSymbol()
        {
            throw new NotImplementedException();
        }

        public IIonSymbol NewSymbol(string text)
        {
            throw new NotImplementedException();
        }

        public IIonSymbol NewSymbol(SymbolToken token)
        {
            throw new NotImplementedException();
        }

        public IIonTimestamp NewNullTimestamp()
        {
            throw new NotImplementedException();
        }

        public IIonTimestamp NewTimestamp(DateTimeOffset dateTimeOffset)
        {
            throw new NotImplementedException();
        }
    }
}
