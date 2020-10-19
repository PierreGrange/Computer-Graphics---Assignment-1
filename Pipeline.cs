using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Pipeline : MonoBehaviour
{
    Matrix4x4 translation, rotation, scale, viewing, projection, transformations;
    // Start is called before the first frame update
    void Start()
    {
        Model P = new Model(Model.default_primitives.P);
        CreateUnityGameObject(P);
        List<Vector3> original = P._vertices;

        rotation = Matrix4x4.Rotate(Quaternion.AngleAxis(13f, new Vector3(16, -3, -3).normalized));
        scale = Matrix4x4.Scale(new Vector3(16, 2, 3));
        translation = Matrix4x4.Translate(new Vector3(-2, 1, -2));

        viewing = Matrix4x4.LookAt(new Vector3(18, 0, 47), new Vector3(-3, 16, -3).normalized, new Vector3(-2, -3, 16).normalized);
        projection = Matrix4x4.Perspective(45f, (1024f/769f), 1, 1000);

        Matrix4x4 rotationscale = rotation * scale;
        transformations = rotation * scale * translation;

        List<Vector3> rotated_P = find_image_of(original, rotation);
        List<Vector3> rotatedandscaled_P = find_image_of(original, rotationscale);
        List<Vector3> transformed_P = find_image_of(original, transformations);

        Matrix4x4 everythingMatrix = transformations * viewing * projection;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private List<Vector3> find_image_of(List<Vector3> vertices, Matrix4x4 transformations)
    {
        List<Vector3> new_image = new List<Vector3>();
        foreach (Vector3 v in vertices)
            new_image.Add(transformations * v);

        return new_image;
    }


    public GameObject CreateUnityGameObject(Model model)
    {
        Mesh mesh = new Mesh();
        GameObject newGO = new GameObject();
        MeshFilter mesh_filter = newGO.AddComponent<MeshFilter>();
        MeshRenderer mesh_renderer = newGO.AddComponent<MeshRenderer>();




        List<Vector3> coords = new List<Vector3>();
        List<int> dummy_indices = new List<int>();
        List<Vector2> text_coords = new List<Vector2>();
        List<Vector3> normals = new List<Vector3>();

        for (int i = 0; i <= model._index_list.Count - 3; i = i + 3)
        {
            Vector3 normal_for_face = model._face_normals[i / 3];
            normal_for_face = new Vector3(normal_for_face.x, normal_for_face.y, -normal_for_face.z);
            coords.Add(model._vertices[model._index_list[i]]); dummy_indices.Add(i); text_coords.Add(model._texture_coordinates[model._texture_index_list[i]]); normals.Add(normal_for_face);
            coords.Add(model._vertices[model._index_list[i + 1]]); dummy_indices.Add(i + 1); text_coords.Add(model._texture_coordinates[model._texture_index_list[i + 1]]); normals.Add(normal_for_face);
            coords.Add(model._vertices[model._index_list[i + 2]]); dummy_indices.Add(i + 2); text_coords.Add(model._texture_coordinates[model._texture_index_list[i + 2]]); normals.Add(normal_for_face);
        }

        mesh.vertices = coords.ToArray();
        mesh.triangles = dummy_indices.ToArray();
        mesh.uv = text_coords.ToArray();
        mesh.normals = normals.ToArray(); ;

        mesh_filter.mesh = mesh;
        return newGO;

    }
}