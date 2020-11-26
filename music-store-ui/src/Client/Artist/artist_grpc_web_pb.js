/**
 * @fileoverview gRPC-Web generated client stub for artist
 * @enhanceable
 * @public
 */

// GENERATED CODE -- DO NOT EDIT!


/* eslint-disable */
// @ts-nocheck



const grpc = {};
grpc.web = require('grpc-web');


var google_protobuf_timestamp_pb = require('google-protobuf/google/protobuf/timestamp_pb.js')
const proto = {};
proto.artist = require('./artist_pb.js');

/**
 * @param {string} hostname
 * @param {?Object} credentials
 * @param {?Object} options
 * @constructor
 * @struct
 * @final
 */
proto.artist.ArtistServiceClient =
    function(hostname, credentials, options) {
  if (!options) options = {};
  options['format'] = 'text';

  /**
   * @private @const {!grpc.web.GrpcWebClientBase} The client
   */
  this.client_ = new grpc.web.GrpcWebClientBase(options);

  /**
   * @private @const {string} The hostname
   */
  this.hostname_ = hostname;

};


/**
 * @param {string} hostname
 * @param {?Object} credentials
 * @param {?Object} options
 * @constructor
 * @struct
 * @final
 */
proto.artist.ArtistServicePromiseClient =
    function(hostname, credentials, options) {
  if (!options) options = {};
  options['format'] = 'text';

  /**
   * @private @const {!grpc.web.GrpcWebClientBase} The client
   */
  this.client_ = new grpc.web.GrpcWebClientBase(options);

  /**
   * @private @const {string} The hostname
   */
  this.hostname_ = hostname;

};


/**
 * @const
 * @type {!grpc.web.MethodDescriptor<
 *   !proto.artist.ArtistListPaginatedRequest,
 *   !proto.artist.ArtistListPaginatedResponse>}
 */
const methodDescriptor_ArtistService_ArtistListPaginate = new grpc.web.MethodDescriptor(
  '/artist.ArtistService/ArtistListPaginate',
  grpc.web.MethodType.UNARY,
  proto.artist.ArtistListPaginatedRequest,
  proto.artist.ArtistListPaginatedResponse,
  /**
   * @param {!proto.artist.ArtistListPaginatedRequest} request
   * @return {!Uint8Array}
   */
  function(request) {
    return request.serializeBinary();
  },
  proto.artist.ArtistListPaginatedResponse.deserializeBinary
);


/**
 * @const
 * @type {!grpc.web.AbstractClientBase.MethodInfo<
 *   !proto.artist.ArtistListPaginatedRequest,
 *   !proto.artist.ArtistListPaginatedResponse>}
 */
const methodInfo_ArtistService_ArtistListPaginate = new grpc.web.AbstractClientBase.MethodInfo(
  proto.artist.ArtistListPaginatedResponse,
  /**
   * @param {!proto.artist.ArtistListPaginatedRequest} request
   * @return {!Uint8Array}
   */
  function(request) {
    return request.serializeBinary();
  },
  proto.artist.ArtistListPaginatedResponse.deserializeBinary
);


/**
 * @param {!proto.artist.ArtistListPaginatedRequest} request The
 *     request proto
 * @param {?Object<string, string>} metadata User defined
 *     call metadata
 * @param {function(?grpc.web.Error, ?proto.artist.ArtistListPaginatedResponse)}
 *     callback The callback function(error, response)
 * @return {!grpc.web.ClientReadableStream<!proto.artist.ArtistListPaginatedResponse>|undefined}
 *     The XHR Node Readable Stream
 */
proto.artist.ArtistServiceClient.prototype.artistListPaginate =
    function(request, metadata, callback) {
  return this.client_.rpcCall(this.hostname_ +
      '/artist.ArtistService/ArtistListPaginate',
      request,
      metadata || {},
      methodDescriptor_ArtistService_ArtistListPaginate,
      callback);
};


/**
 * @param {!proto.artist.ArtistListPaginatedRequest} request The
 *     request proto
 * @param {?Object<string, string>} metadata User defined
 *     call metadata
 * @return {!Promise<!proto.artist.ArtistListPaginatedResponse>}
 *     Promise that resolves to the response
 */
proto.artist.ArtistServicePromiseClient.prototype.artistListPaginate =
    function(request, metadata) {
  return this.client_.unaryCall(this.hostname_ +
      '/artist.ArtistService/ArtistListPaginate',
      request,
      metadata || {},
      methodDescriptor_ArtistService_ArtistListPaginate);
};


module.exports = proto.artist;

