using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _back;
    [SerializeField] private CharacterView _characterView;

    private SpriteAnimator _spriteAnimator;
    //add links to test views <1>

    //private SomeManager _someManager;
    //add links to some logic managers <2>

    private void Start()
    {
        SpriteAnimationsConfig config = Resources.Load<SpriteAnimationsConfig>("Configs/SpriteAnimationsConfig");

        _spriteAnimator = new SpriteAnimator(config);
        
        
        _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, Track.idle, true, 10);

        //SomeConfig config = Resources.Load("SomeConfig", typeof(SomeConfig))as   SomeConfig;
        //load some configs here <3>

        //_someManager = new SomeManager(config);
        //create some logic managers here for tests <4>

    }

    private void Update()
    {
        _spriteAnimator.Update();
    }

    private void FixedUpdate()
    {
        //_someManager.FixedUpdate();
        //update logic managers here <6>
    }

    private void OnDestroy()
    {
        //_someManager.Dispose();
        //dispose logic managers here <7>
    }
}