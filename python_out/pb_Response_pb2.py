# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: pb_Response.proto
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='pb_Response.proto',
  package='',
  syntax='proto3',
  serialized_options=None,
  create_key=_descriptor._internal_create_key,
  serialized_pb=b'\n\x11pb_Response.proto\"\xfa\x02\n\x0bpb_Response\x12,\n\x0bstatus_code\x18\x01 \x01(\x0e\x32\x17.pb_Response.StatusCode\x12#\n\x06reason\x18\x02 \x01(\x0e\x32\x13.pb_Response.Reason\"A\n\nStatusCode\x12\x0b\n\x07UNKNOWN\x10\x00\x12\x06\n\x02OK\x10\x01\x12\r\n\tNOT_FOUND\x10\x02\x12\x0f\n\x0b\x42\x41\x44_REQUEST\x10\x03\"\xd4\x01\n\x06Reason\x12\x08\n\x04NONE\x10\x00\x12\x19\n\x15SOURCE_NOT_REGISTERED\x10\x01\x12\x1e\n\x1a\x44\x45STINATION_NOT_REGISTERED\x10\x02\x12!\n\x1d\x45NDPOINT_REGISTRATION_SUCCESS\x10\x03\x12\x33\n/ENDPOINT_REGISTRATION_FAILED_ALREADY_REGISTERED\x10\x04\x12-\n)ENDPOINT_REGISTRATION_FAILED_NAME_IN_USED\x10\x05\x62\x06proto3'
)



_PB_RESPONSE_STATUSCODE = _descriptor.EnumDescriptor(
  name='StatusCode',
  full_name='pb_Response.StatusCode',
  filename=None,
  file=DESCRIPTOR,
  create_key=_descriptor._internal_create_key,
  values=[
    _descriptor.EnumValueDescriptor(
      name='UNKNOWN', index=0, number=0,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='OK', index=1, number=1,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='NOT_FOUND', index=2, number=2,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='BAD_REQUEST', index=3, number=3,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
  ],
  containing_type=None,
  serialized_options=None,
  serialized_start=120,
  serialized_end=185,
)
_sym_db.RegisterEnumDescriptor(_PB_RESPONSE_STATUSCODE)

_PB_RESPONSE_REASON = _descriptor.EnumDescriptor(
  name='Reason',
  full_name='pb_Response.Reason',
  filename=None,
  file=DESCRIPTOR,
  create_key=_descriptor._internal_create_key,
  values=[
    _descriptor.EnumValueDescriptor(
      name='NONE', index=0, number=0,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='SOURCE_NOT_REGISTERED', index=1, number=1,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='DESTINATION_NOT_REGISTERED', index=2, number=2,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='ENDPOINT_REGISTRATION_SUCCESS', index=3, number=3,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='ENDPOINT_REGISTRATION_FAILED_ALREADY_REGISTERED', index=4, number=4,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='ENDPOINT_REGISTRATION_FAILED_NAME_IN_USED', index=5, number=5,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
  ],
  containing_type=None,
  serialized_options=None,
  serialized_start=188,
  serialized_end=400,
)
_sym_db.RegisterEnumDescriptor(_PB_RESPONSE_REASON)


_PB_RESPONSE = _descriptor.Descriptor(
  name='pb_Response',
  full_name='pb_Response',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='status_code', full_name='pb_Response.status_code', index=0,
      number=1, type=14, cpp_type=8, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='reason', full_name='pb_Response.reason', index=1,
      number=2, type=14, cpp_type=8, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
    _PB_RESPONSE_STATUSCODE,
    _PB_RESPONSE_REASON,
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=22,
  serialized_end=400,
)

_PB_RESPONSE.fields_by_name['status_code'].enum_type = _PB_RESPONSE_STATUSCODE
_PB_RESPONSE.fields_by_name['reason'].enum_type = _PB_RESPONSE_REASON
_PB_RESPONSE_STATUSCODE.containing_type = _PB_RESPONSE
_PB_RESPONSE_REASON.containing_type = _PB_RESPONSE
DESCRIPTOR.message_types_by_name['pb_Response'] = _PB_RESPONSE
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

pb_Response = _reflection.GeneratedProtocolMessageType('pb_Response', (_message.Message,), {
  'DESCRIPTOR' : _PB_RESPONSE,
  '__module__' : 'pb_Response_pb2'
  # @@protoc_insertion_point(class_scope:pb_Response)
  })
_sym_db.RegisterMessage(pb_Response)


# @@protoc_insertion_point(module_scope)
